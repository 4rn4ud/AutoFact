using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoFact
{


    class Product : Interface1

    {
        private int id;
        private string libel;
        private double unitprice;


        public Product(string thelibel, double theunitprice)
        {
            this.libel = thelibel;
            this.unitprice = theunitprice;

        }


        public Product(int theid, string thelibel, double theunitprice)
        {
            this.id = theid;
            this.libel = thelibel;
            this.unitprice = theunitprice;

        }
        public override string ToString()

        {
           return this.id+","+this.libel;


        }


        public static Product get(int id)
        {
            Product product = null;
            using (SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    conn.Open();

                    cmd.CommandText = "SELECT * FROM product WHERE id = @id";
                    cmd.Connection = conn;
                    cmd.Parameters.Add(new SQLiteParameter("@id", id));

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            product = new Product(
                                Convert.ToInt32(dr["id"]),
                                dr["libel"].ToString(),
                                Convert.ToInt32(dr["unitprice"])
                            );
                            break;
                        }
                    }

                    conn.Close();
                }
            }
            return product;
        }

        public int getId()
        {
            return this.id;
        }
        public string getLibel()
        {
            return this.libel;

        }
        public void setLibel(string onelibel)
        {


            this.libel = onelibel.Trim();

        }
        public double getUnitprice()
        {
            return this.unitprice;
        }
        public void setUnitprice(double oneinitprice)
        {
            this.unitprice = oneinitprice;
        }

        public bool insert()
        {
            int count;
            using (SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {




                    conn.Open();
                    string strSql = "INSERT INTO[product] ([libel],[unitprice]) " +
                        "VALUES(@libel,@unitprice)";

                    cmd.Parameters.AddWithValue("@libel", libel);
                    cmd.Parameters.AddWithValue("@unitprice", unitprice);



                    cmd.CommandText = strSql;
                    cmd.Connection = conn;
                    count = cmd.ExecuteNonQuery();
                    conn.Close();


                }
            }

            return count != 0;
        }
        public bool update()
        {
            int count;
            using (SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {




                    conn.Open();
                    string strSql = "UPDATE product SET libel = @libel, unitprice = @unitprice WHERE id =@oneid";


                    cmd.Parameters.AddWithValue("@libel", libel);
                    cmd.Parameters.AddWithValue("@oneid", id);
                    cmd.Parameters.AddWithValue("@unitprice", unitprice);

                    cmd.CommandText = strSql;
                    cmd.Connection = conn;
                    count = cmd.ExecuteNonQuery();
                    conn.Close();


                }
            }

            return count != 0;
        }
    }
}

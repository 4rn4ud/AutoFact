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


    class Product

    {
        private int id;
        private string libel;
        private double unitprice;
        SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        SQLiteCommand cmd = new SQLiteCommand();


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
            return this.id + "," + this.libel;


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

            conn.Open();
            string strSql = "INSERT INTO[product] ([libel],[unitprice]) " +
                "VALUES(@libel,@unitprice)";

            cmd.Parameters.AddWithValue("@libel", libel);
            cmd.Parameters.AddWithValue("@unitprice", unitprice);
            cmd.CommandText = strSql;
            cmd.Connection = conn;
            count = cmd.ExecuteNonQuery();
            conn.Close();




            return count != 0;
        }
        public bool update()
        {
            int count;
            conn.Open();
            string strSql = "UPDATE product SET libel = @libel, unitprice = @unitprice WHERE id =@oneid";
            cmd.Parameters.AddWithValue("@libel", libel);
            cmd.Parameters.AddWithValue("@oneid", id);
            cmd.Parameters.AddWithValue("@unitprice", unitprice);
            cmd.CommandText = strSql;
            cmd.Connection = conn;
            count = cmd.ExecuteNonQuery();
            conn.Close();

            return count != 0;
        }
    }
}

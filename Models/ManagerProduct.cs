using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact.Models
{
    internal class ManagerProduct
    {
        public static SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        public static SQLiteDataAdapter adapter;
        public static SQLiteCommand cmd;


        public static List<Product> getAllProduct()
        {
            List<Product> list = new List<Product>();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * ");
            query.Append("FROM product ");

            cmd = new SQLiteCommand(query.ToString(), conn);

            conn.Open();

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(new Product(Convert.ToInt32(dr["id"]), dr["libel"].ToString(), Convert.ToDouble(dr["unitprice"])));
                }
            }

            conn.Close();
            return list;

        }
    }
}

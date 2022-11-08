using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    internal class ManagerQuote
    {
        public static SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        public static SQLiteDataAdapter adapter;
        public static SQLiteCommand cmd;


        public static List<Quote> getAllQuote()
        {
            List<Quote> list = new List<Quote>();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * ");
            query.Append("FROM quote ");

            cmd = new SQLiteCommand(query.ToString(), conn);

            conn.Open();

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(new Quote(Convert.ToInt32(dr["id"]), Convert.ToInt32(dr["idcustomers"])));
                }
            }

            return list;

            conn.Close();
        }
    }
}

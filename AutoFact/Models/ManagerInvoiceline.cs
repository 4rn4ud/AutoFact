using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact.Models
{
    internal class ManagerInvoiceline
    {

        public static SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        public static SQLiteDataAdapter adapter;
        public static SQLiteCommand cmd;


        public static List<Invoiceline> getAllInvoiceline()
        {
            List<Invoiceline> list = new List<Invoiceline>();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * ");
            query.Append("FROM invoiceline ");

            cmd = new SQLiteCommand(query.ToString(), conn);

            conn.Open();

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(new Invoiceline(Convert.ToInt32(dr["idproduct"]), Convert.ToInt32(dr["idquote"]), Convert.ToInt32(dr["quantity"]), Convert.ToInt32(dr["promotion"])));
                }
            }
            conn.Close();
            return list;


        }
    }
}

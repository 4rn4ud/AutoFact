using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact.Models
{
    public static class ManagerCustomers
    {
        public static SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        public static SQLiteDataAdapter adapter;
        public static SQLiteCommand cmd;


        public static List<Customer> getAllCustomer()
        {
            List<Customer> list = new List<Customer>();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * ");
            query.Append("FROM customers ");

            cmd = new SQLiteCommand(query.ToString(), conn);

            conn.Open();

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(new Customer(Convert.ToInt32(dr["id"]), dr["name"].ToString(), dr["lastname"].ToString(), dr["companyname"].ToString(), Convert.ToInt32(dr["postalcode"]), dr["adress"].ToString(), dr["city"].ToString(), dr["mail"].ToString(), Convert.ToInt32(dr["tel"])));
                }
            }
            conn.Close();

            return list;
        }

      
    }
}

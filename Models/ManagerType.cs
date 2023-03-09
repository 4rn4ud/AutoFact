using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact.Models
{
    internal class ManagerType
    {
        public static SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        public static SQLiteDataAdapter adapter;
        public static SQLiteCommand cmd;


        public static List<Type> getAllType()
        {
            List<Type> list = new List<Type>();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * ");
            query.Append("FROM type");

            cmd = new SQLiteCommand(query.ToString(), conn);

            conn.Open();

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(new Type(Convert.ToInt32(dr["id"]), dr["libel"].ToString()));
                }
            }
            conn.Close();
            return list;

        }
    }
}

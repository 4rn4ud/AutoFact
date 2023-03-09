using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact.Models
{
    internal class ManagerProfile
    {
        public static SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        public static SQLiteDataAdapter adapter;
        public static SQLiteCommand cmd;


        public static List<Profile> getAllProfile()
        {
            List<Profile> list = new List<Profile>();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * ");
            query.Append("FROM profile");

            cmd = new SQLiteCommand(query.ToString(), conn);

            conn.Open();

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(new Profile(Convert.ToInt32(dr["id"]), dr["companyname"].ToString(), dr["adress"].ToString(), Convert.ToInt32(dr["postalcode"]), dr["city"].ToString(), Convert.ToInt32(dr["tel"]), dr["email"].ToString(), Convert.ToInt32(dr["siren"])));
                }
            }
            conn.Close();
            return list;


        }
    }
}

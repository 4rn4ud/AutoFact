using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact.Models
{
    internal class ManagerStatus
    {
        public static SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        public static SQLiteDataAdapter adapter;
        public static SQLiteCommand cmd;


        public static List<Status> getAllStatus()
        {
            List<Status> list = new List<Status>();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * ");
            query.Append("FROM status ");

            cmd = new SQLiteCommand(query.ToString(), conn);

            conn.Open();

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(new Status(Convert.ToDateTime(dr["date"]), Convert.ToInt32(dr["idquote"]), Convert.ToInt32(dr["idtype"])));
                }
            }
            conn.Close();
            return list;

        }
        public static List<Status> getStatus()
        {
            List<Status> list = new List<Status>();
            StringBuilder query = new StringBuilder();
            query.Append("select * from status group by idquote having max(idtype)");

            cmd = new SQLiteCommand(query.ToString(), conn);

            conn.Open();

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(new Status(Convert.ToDateTime(dr["date"]), Convert.ToInt32(dr["idquote"]), Convert.ToInt32(dr["idtype"])));
                }
            }
            conn.Close();
            return list;

        }
    }
}

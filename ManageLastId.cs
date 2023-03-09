using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact
{
    public class ManageLastId
    {
        public static SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        public static SQLiteDataAdapter adapter;
        public static SQLiteCommand cmd;


        public static int getLastId()
        {
            conn.Open();

            StringBuilder query = new StringBuilder();
            query.Append("SELECT last_insert_rowid()");
            

            cmd = new SQLiteCommand(query.ToString(), conn);

            
            int lastid= new int();
            SQLiteDataReader command = cmd.ExecuteReader();
            if (command.Read())
            {
                lastid = command.GetInt32(0);
            }
           
            conn.Close();
            return lastid;
        }

    }
}

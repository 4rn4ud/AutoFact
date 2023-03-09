using AutoFact.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
     class Status 
    {
        private DateTime date;
        private int _idquote;
        private int _idtype;
        SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        SQLiteCommand cmd = new SQLiteCommand();





        public Status(DateTime thedate, int thequote, int thetype)
        {
            this.date = thedate;
            this._idquote = thequote;
            this._idtype = thetype;
           

        }
        public override string ToString()

        {
            return this._idquote.ToString()+","+ this.getTypeLibel() ;

        }
        public DateTime getDate() 
        { 
            return this.date; 
        }
        public void setDate(DateTime onedate)
        {
            this.date = onedate;
        }
        public int getidQuote()
        {
            return this._idquote;
        }

        public int getType()
        {
            return this._idtype;
        }
        public string getTypeLibel()
        {
            string thetypelibel ="";
            foreach (Type thetype in ManagerType.getAllType())
            {
                if (thetype.getId() == this._idtype)
                {
                    thetypelibel = thetype.getLibel();
                }
            }
            return thetypelibel;
        }
         
       public bool insert()
        {
            int count;

            conn.Open();
            string strSql = "INSERT INTO[status] ([date],[idquote],[idtype]) " +
                "VALUES(@date,@idquote,@idtype)";


            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@idquote", _idquote);
            cmd.Parameters.AddWithValue("@idtype", _idtype);
            cmd.CommandText = strSql;
            cmd.Connection = conn;
            count = cmd.ExecuteNonQuery();

            conn.Close();
            return count != 0;
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    class Quote 
    {
        private int id;
        private int _idcustomer;
        private List<Invoiceline> invoicelines = new List<Invoiceline>();
        SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        SQLiteCommand cmd = new SQLiteCommand();



        public Quote(int thecustomer)
        {

            this._idcustomer = thecustomer;
            this.invoicelines = new List<Invoiceline>();
        }
        public Quote(int theid, int thecustomer)
        {
            this.id = theid;
            this._idcustomer = thecustomer;
            this.invoicelines = new List<Invoiceline>();
        }
        public int getId()
        {
            return this.id;
        }
        public int getCustomer()
        {
            return this._idcustomer;
        }
        public void setCustomers(int onecustomers)
        {
            this._idcustomer = onecustomers;
        }
        public void addInvoiceline(Invoiceline oneinvoice)
        {
            this.invoicelines.Add(oneinvoice);
        }
        public List<Invoiceline> getInvoicelines()
        {
            return this.invoicelines;
        }

        public int insert()
        {
            int lastid = new int();
            conn.Open();
            string strSql = "INSERT INTO[quote] ([idcustomers]) VALUES(@idcustomers);SELECT last_insert_rowid()";

            cmd.Parameters.AddWithValue("@idcustomers", _idcustomer);
            cmd.CommandText = strSql;
            cmd.Connection = conn;

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

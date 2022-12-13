using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
     class Quote : Interface1
    {
        private int id;
        private int _idcustomer;
        private List<Invoiceline> invoicelines = new List<Invoiceline>();



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

        public bool insert()
        {
            int count;
            using (SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {




                    conn.Open();
                    string strSql = "INSERT INTO[quote] ([idcustomers]) " +
                        "VALUES(@idcustomers)";

                    cmd.Parameters.AddWithValue("@idcustomers",_idcustomer );
                    



                    cmd.CommandText = strSql;
                    cmd.Connection = conn;
                    count = cmd.ExecuteNonQuery();
                    conn.Close();


                }
            }

            return count != 0;
        }
        
       


    }
}

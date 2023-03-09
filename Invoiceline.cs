using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
     class Invoiceline
     {
        private int _idproduct;
        private int _idquote;
        private int quantity;
        private int promotion;
        private double unitprice;
        SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db");
        SQLiteCommand cmd = new SQLiteCommand();


        public Invoiceline(int productId, int thequote, int thequantity,int thepromotion, double theunitprice)
        {
            this.quantity = thequantity;
            this.promotion = thepromotion;
            this._idquote = thequote;
            this._idproduct = productId;
            this.unitprice = theunitprice;
            
        }
        public int getQuantity()
        {
            return this.quantity;
        }
        public void setQuantity(int onequantity)
        {
            this.quantity=onequantity;
        }
        public int GetPromotion()
        {
            return this.promotion;
        }
        public void setPromotion(int thepromotion)
        {
            this.promotion=thepromotion;
        }
        public int getIdQuote()
        {
            return this._idquote;
        }
      
        public int getProduct()
        {
            return this._idproduct;
        }
        public double getUnitprice()
        {
            return this.unitprice;
        }
        public void setUnitPrice(double oneunitprice)
        {
            this.unitprice=oneunitprice;
        }
        public bool insert()
        {
            int count;

            conn.Open();
            string strSql = "INSERT INTO[invoiceline] ([idproduct],[idquote],[quantity],[promotion],[unitprice]) " +
                "VALUES(@idproduct,@idquote,@quantity,@promotion,@unitprice)";


            cmd.Parameters.AddWithValue("@idproduct", _idproduct);
            cmd.Parameters.AddWithValue("@idquote", _idquote);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@promotion", promotion);
            cmd.Parameters.AddWithValue("@unitprice", unitprice);
            cmd.CommandText = strSql;
            cmd.Connection = conn;
            count = cmd.ExecuteNonQuery();
            conn.Close();
            return count != 0;
        }
     }
}

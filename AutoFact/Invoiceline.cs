using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
     class Invoiceline
    {
        private int quantity;
        private int promotion;
        private Quote _idquote;
        private Product _idproduct;


        public Invoiceline(int thequantity,int thepromotion, Quote thequote, Product theproduct)
        {
            this.quantity = thequantity;
            this.promotion = thepromotion;
            this._idquote = thequote;
            this._idproduct = theproduct;
            
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
        public Quote getCommand()
        {
            return this._idquote;
        }
       
        public Product getProduct()
        {
            return this._idproduct;
        }
      
        }
    }
}

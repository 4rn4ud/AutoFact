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
        private int _idquote;
        private int _productId;


        public Invoiceline(int thequantity,int thepromotion, int thequote, int productId)
        {
            this.quantity = thequantity;
            this.promotion = thepromotion;
            this._idquote = thequote;
            this._productId = productId;
            
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
      
        public Product getProduct()
        {
            return Product.get(_productId);
        }
     }
}

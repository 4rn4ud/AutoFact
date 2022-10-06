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
        private Quote _command;
        private Product _product;


        public Invoiceline(int thequantity,int thepromotion, Quote thecommand, Product theproduct)
        {
            this.quantity = thequantity;
            this.promotion = thepromotion;
            this._command = thecommand;
            this._product = theproduct;
            
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
            return this._command;
        }
        public void setCommand(Quote onecommand)
        {
            this._command=onecommand;
        }
        public Product getProduct()
        {
            return this._product;
        }
        public void setProduct(Product oneproduct)
        {
            this._product = oneproduct;
        }
    }
}

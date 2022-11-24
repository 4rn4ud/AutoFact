﻿using System;
using System.Collections.Generic;
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
        

        public Quote(int theid, int thecustomer)
        {
            this.id = theid;
            this._idcustomer = thecustomer;
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
        
    }
}

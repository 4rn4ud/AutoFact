using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
     class Quote
    {
        private int id;
        private Customers _customers;

        public Quote(int theid, Customers thecustomer)
        {
            this.id = theid;
            this._customers = thecustomer;
        }
        public int getId()
        {
            return this.id;
        }
        public Customers getCustomer()
        {
            return this._customers;
        }
        public void setCustomers(Customers onecustomers)
        {
            this._customers = onecustomers;
        }
        
    }
}

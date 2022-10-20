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
        private Customer _customer;

        public Quote(int theid, Customer thecustomer)
        {
            this.id = theid;
            this._customer = thecustomer;
        }
        public int getId()
        {
            return this.id;
        }
        public Customer getCustomer()
        {
            return this._customer;
        }
        public void setCustomers(Customer onecustomers)
        {
            this._customer = onecustomers;
        }
        
    }
}

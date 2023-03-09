using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
     class Credit
    {
        private int id;
        private DateTime date;


        public Credit (int theid, DateTime thedate)
        {
            this.id = theid;
            this.date = thedate;
        }

        public int getId()
        {
            return this.id;
        }
        public DateTime getDate()
        {
            return this.date;
        }
        public void setDate(DateTime onedate)
        {
            this.date = onedate;
        }
    }
}

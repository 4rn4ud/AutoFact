using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
     class Status
    {
        private DateTime date;
        private int _idquote;
        private int _idtype;
        private Type _type;
        



        public Status(DateTime thedate, int thequote, int thetype)
        {
            this.date = thedate;
            this._idquote = thequote;
            this._idtype = thetype;
           

        }
        public DateTime getDate() 
        { 
            return this.date; 
        }
        public void setDate(DateTime onedate)
        {
            this.date = onedate;
        }
        public int getidQuote()
        {
            return this._idquote;
        }

        public int getType()
        {
            return this._idtype;
        }
         
       
        
        
    }
}

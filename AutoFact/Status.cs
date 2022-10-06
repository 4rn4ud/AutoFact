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
        private Quote _quote;
        private Type _type;



        public Status(DateTime thedate, Quote thequote, Type thetype)
        {
            this.date = thedate;
            this._quote = thequote;
            this._type = thetype;
        }
        public DateTime getDate() 
        { 
            return this.date; 
        }
        public void setDate(DateTime onedate)
        {
            this.date = onedate;
        }
        public Quote getQuote()
        {
            return this._quote;
        }
        public void setQuote(Quote onequote)
        {
            this._quote = onequote;
        }
        public Type getType()
        {
            return this._type;
        }
        public void setType(Type onetype)
        {
            this._type = onetype;
        }
    }
}

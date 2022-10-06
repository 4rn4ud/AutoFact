using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
     class Type
    {
        private int id;
        private string libel;


        public Type(int theid, string thelibel)
        {
            this.id = theid;
            this.libel = thelibel.Trim();
        }
        public int getId()
        {
            return this.id;
        }
        public string getLibel()
        {
            return this.libel;
        }
        public void SetLibel(string onelibel)
        { this.libel = onelibel.Trim();
        }
    }
}

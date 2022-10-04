using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    public class Product
    {
        private int id;
        private string libel;
        private int unitprice;


        public Product(int theid, string thelibel, int theunitprice)
        {
            this.id = theid;
            this.libel = thelibel;
            this.unitprice = theunitprice;

        }

        private int getId()
        {
            return this.id;
        }
        public string getLibel()
        {
            return this.libel;

        }
        public void setLibel(string onelibel)
        {
            this.libel = onelibel;
        }
        public int getUnitprice()
        {
            return this.unitprice;
        }
        public void setUnitprice(int oneinitprice)
        {
            this.unitprice = oneinitprice;
        }
    }
}

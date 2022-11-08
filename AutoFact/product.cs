using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{


    class Product

    {
        private int id;
        private string libel;
        private double unitprice;


        public Product(int theid, string thelibel, double theunitprice)
        {
            this.id = theid;
            this.libel = thelibel;
            this.unitprice = theunitprice;

        }

        public int getId()
        {
            return this.id;
        }
        public string getLibel()
        {
            return this.libel;

        }
        public void setLibel(string onelibel)
        {


            this.libel = onelibel.Trim();

        }
        public double getUnitprice()
        {
            return this.unitprice;
        }
        public void setUnitprice(double oneinitprice)
        {
            this.unitprice = oneinitprice;
        }
    }
}

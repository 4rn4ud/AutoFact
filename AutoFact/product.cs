using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Drawing;
using System.Linq;
using System.Security.Policy;
=======
using System.Linq;
>>>>>>> Fatih
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
<<<<<<< HEAD
    public class Product
=======
    class Product
>>>>>>> Fatih
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
<<<<<<< HEAD
            this.libel = onelibel;
=======
            this.libel = onelibel.Trim();
>>>>>>> Fatih
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

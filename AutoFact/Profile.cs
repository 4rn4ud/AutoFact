using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    internal class Profile
    {
        private int id;
        private string companyname;
        private string adress;
        private int postalcode;
        private string city;
        private int tel;
        private string email;


        public Profile(string thecompanyname, string theadress, int thepostalcode, string thecity, int thetel, string theemail)
        {
            this.companyname = thecompanyname;
            this.adress = theadress;
            this.postalcode = thepostalcode;
            this.city = thecity;
            this.tel = thetel;
            this.email = theemail;
        }
        public Profile(int theid, string thecompanyname, string theadress, int thepostalcode, string thecity, int thetel, string theemail)
        {
            this.id=theid;
            this.companyname = thecompanyname;
            this.adress = theadress;
            this.postalcode = thepostalcode;
            this.city = thecity;
            this.tel = thetel;
            this.email = theemail;
        }
        public string getcompanyname()
        {
            return this.companyname;
        }
        
        public string getAdress()
        {
            return this.adress;
        }
        public int getPostalcode()
        {
            return this.postalcode;
        }
        public string getCity()
        {
            return this.city;
        }
        public int getTel()
        {
            return this.tel;
        }
        
        public string getEmail()
        {
            return this.email;
        }

        public void setCompanyname(string onecompanyname)
        {
            this.companyname = onecompanyname;
        }
        public void setAdress(string oneadress)
        {
            this.adress = oneadress;
        }
        public void setPostalCode(int onepostalcode)
        {
            this.postalcode = onepostalcode;
        }
        public void setCity(string onecity)
        {
            this.city = onecity;
        }
        public void setTel(int onetel)
        {
            this.tel = onetel;
        }
    }
}

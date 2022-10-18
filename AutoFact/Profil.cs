using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
     class Profil
    {
        private int id;
        private string companyame;
        private int siren;
        private string adress;
        private string city;
        private int postalcode;
        private int tel;
        private string email;

        public Profil(int theid, string thecompanyname, int thesiren, string theadress, string thecity, int thepostalcode, int thetel, string theemail)
        {
            this.id = theid;
            this.companyame = thecompanyname;
            this.siren = thesiren;
            this.adress = theadress;
            this.city = thecity;
            this.postalcode = thepostalcode;
            this.tel = thetel;
            this.email = theemail;
        }

        public int getId()
        {
            return this.id;
        }
        public string getCompanyname()
        {
            return this.companyame;
        }
        public void setComptanyname(string newcompanyname)
        {
            this.companyame=newcompanyname.Trim();
        }
        public int getSiren()
        {
            return this.siren;
        }
        public void setSiren(int newsiren)
        {
            this.siren = newsiren;
        }
        public string getAdress() 
        {
            return this.adress;
        }
        public void setAdress(string newadress)
        {
            this.adress = newadress.Trim();
        }
        public string getCity()
        {
            return this.city;
        }
        public void setCity(string newcity)
        {
            this.city = newcity.Trim();
        }
        public int getPostalcode()
        {
            return this.postalcode;
        }
        public void setPostalcode(int newpostalcode)
        {
            this.postalcode = newpostalcode;
        }
        public int getTel()
        {
            return this.tel;
        }
        public void setTel(int newtel)
        {
            this.tel = newtel;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string newemail)
        {
            this.email = newemail.Trim();
        }
    }
}

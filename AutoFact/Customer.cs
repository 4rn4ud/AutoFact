﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
     public class Customer
    {
        private int id;
        private string name;
        private string lastname;
        private string companyname;
        private int postalcode;
        private string adress;
        private string city;
        private string mail;
        private int tel;

        public Customer(int theid, string thename, string thelastname, string thecompanyname, int postalcode
            , string theadress, string thecity, string themail, int thetel)
        {

            this.id = theid;
            this.name = thename;
            this.lastname = thelastname;
            this.companyname = thecompanyname;
            this.postalcode = postalcode;
            this.adress = theadress;
            this.city = thecity;
            this.mail = themail;    
            this.tel = thetel;

        }
        public int getId()
        {
            return this.id;

        }
        public string getName()
        {
            return this.name;
        }
        public void setName(string onename)
        {
            this.name = onename.Trim();
        }
        public string getLastname()
        {
            return this.lastname;
        }
        public void setLastname(string onelastname)
        {
            this.name = onelastname.Trim();
        }
        public string getCompanyName()
        {
            return this.companyname;
        }
        public void setlastname(string onecompanyname)
        {
            this.companyname = onecompanyname.Trim();
        }
        public int getPostalcode()
        {
            return this.postalcode;
        }
        public void setPostalcode(int codepostal)
        {
            this.postalcode = codepostal;
        }
        public string getAdress()
        {
            return this.adress;
        }
        public void setAdress(string oneadress)
        {
            this.adress = oneadress.Trim();
        }
        public string getCity()
        {
            return this.city;
        }
        public void setCity(string onecity)
        {
            this.city = onecity.Trim();
        }

        
        public int getTel()
        {
            return this.tel;
        }
        public void setTel(int onetel)
        {
            this.tel = onetel;
        }

        public string getMail()
        {
            return this.mail;
        }
        public void setMail(string onemail)
        {
            this.mail = onemail.Trim();
        }


    }
}
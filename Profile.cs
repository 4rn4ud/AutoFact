using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        private int siren;


        public Profile(string thecompanyname, string theadress, int thepostalcode, string thecity, int thetel, string theemail, int thesiren)
        {
            this.companyname = thecompanyname;
            this.adress = theadress;
            this.postalcode = thepostalcode;
            this.city = thecity;
            this.tel = thetel;
            this.email = theemail;
            this.siren = thesiren;
        }
        public Profile(int theid, string thecompanyname, string theadress, int thepostalcode, string thecity, int thetel, string theemail,int thesiren)
        {
            this.id=theid;
            this.companyname = thecompanyname;
            this.adress = theadress;
            this.postalcode = thepostalcode;
            this.city = thecity;
            this.tel = thetel;
            this.email = theemail;
            this.siren=thesiren;
        }
        public int getId()
        {
            return this.id;
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
        public void setEmail(string onemail)
        {
            this.email = onemail;
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
        public int getSiren()
        {
            return this.siren;
        }
        public void setSiren(int onesiren)
        {
            this.siren= onesiren;
        }
        public bool update()
        {
            int count;
            using (SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {

                    conn.Open();
                    string strSql = "UPDATE profile SET companyname = @companyname, postalcode =@postalcode, adress = @adress, city =@city, email = @email, tel = @tel, siren= @siren WHERE id =@oneid";
                    cmd.Parameters.AddWithValue("@oneid", id);
                    cmd.Parameters.AddWithValue("@companyname", companyname);
                    cmd.Parameters.AddWithValue("@postalcode", postalcode);
                    cmd.Parameters.AddWithValue("@adress", adress);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@siren", siren);



                    cmd.CommandText = strSql;
                    cmd.Connection = conn;
                    count = cmd.ExecuteNonQuery();
                    conn.Close();




                }
            }
            return count != 0;
        }
    }
}

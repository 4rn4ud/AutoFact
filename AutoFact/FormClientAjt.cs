using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
//using System.Windows.Forms;


namespace AutoFact
{
    public partial class FormClientAjt : Form
    {
        public FormClientAjt()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            this.Hide();
            Menu.Show();
        }



        private void butAddCust_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("DataSource = mydatabase.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string onename = TxtCustName.Text.Trim();
                    string onelastname = TxtCustLastName.Text.Trim();
                    string onecompanyname = TxtCustCompany.Text.Trim();
                    int onepostalcode = Convert.ToInt32(TxtCustPostal.Text.Trim());
                    string oneadress = TxtCustAdress.Text.Trim();
                    string onecity = TxtCustCity.Text.Trim();
                    string onemail = TxtCustMail.Text.Trim();
                    int onetel = Convert.ToInt32(TxtCustTel.Text.Trim());



                    conn.Open();
                    string strSql = "INSERT INTO[customers] ([name],[lastname],[companyname],[postalcode],[adress],[city],[mail],[tel]) " +
                        "VALUES(@name,@lastname,@companyname,@postalcode,@adress,@city,@mail,@tel)";

                    cmd.Parameters.AddWithValue("@name", onename);
                    cmd.Parameters.AddWithValue("@lastname", onelastname);
                    cmd.Parameters.AddWithValue("@companyname", onecompanyname);
                    cmd.Parameters.AddWithValue("@postalcode", onepostalcode);
                    cmd.Parameters.AddWithValue("@adress", oneadress);
                    cmd.Parameters.AddWithValue("@city", onecity);
                    cmd.Parameters.AddWithValue("@mail", onemail);
                    cmd.Parameters.AddWithValue("@tel", onetel);


                    cmd.CommandText = strSql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }

        }
        

        private void FormClientA_Load(object sender, EventArgs e)
        { 

        
        }
            
    }
}
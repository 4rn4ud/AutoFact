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
    public partial class FormClientA : Form
    {
        public FormClientA()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            this.Hide();
            Menu.Show();
        }

        private void WriteSQLite()
        {
            using (SQLiteConnection conn = new SQLiteConnection("DataSource = C:\\Users\\clapier\\Documents\\GitHub\\AutoFact\\AutoFact\\bin\\Debug\\mydatabase.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {



                    string lenom = this.TxtClientName.Text;
                    string lenomdefamille = this.TxtClientLastName.Text;
                    string lenomentreprise = this.TxtClientCompany.Text;
                    string lecodepostal = this.TxtClientPostal.Text;
                    string uneadresse = this.TxtClientAdress.Text;
                    string laville = this.TxtClientCity.Text;
                    string lemail = this.TxtClientMail.Text;
                    string letel = this.TxtClientTel.Text;


                    string strSql = "INSERT INTO[customers] ([name],[lastname],[companyname],[postalcode],[adress],[city],[mail],[tel]) VALUES(@Nom, @nomfamille, @nomentreprise, @codepostal, @adresse, @ville, @mail, @tel)";

                    cmd.Parameters.AddWithValue("@Nom", lenom);

                    cmd.Parameters.AddWithValue("@nomfamille", lenomdefamille);
                    cmd.Parameters.AddWithValue("@nomentreprise", lenomentreprise);
                    cmd.Parameters.AddWithValue("@codepostal", lecodepostal);
                    cmd.Parameters.AddWithValue("@adresse", uneadresse);
                    cmd.Parameters.AddWithValue("@ville", laville);
                    cmd.Parameters.AddWithValue("@mail", lemail);
                    cmd.Parameters.AddWithValue("@tel", letel);


                    cmd.CommandText = strSql;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();

                    // do something…

                    conn.Close();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            WriteSQLite();

        }
    }
}
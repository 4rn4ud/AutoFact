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

        private  void WriteSQLite()
        {
                using (SQLiteConnection conn = new SQLiteConnection("DataSource = C:\\Users\\taskin\\Documents\\GitHub\\AutoFact\\AutoFact\\bin\\Debug\\mydatabase.db"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {

                    //name texte As String = Me.TxtClientName.Text;

                    string lenom = this.TxtClientName.Text; 


                    string strSql = "INSERT INTO[customers] ([name],[lastname],[companyname],[postalcode],[adress],[city],[mail],[tel]) VALUES(@Nom, 'nomdefamille', 'nomentreprise', 78224, 'adresse', 'laville', 'lemail', 'letel')";
                    cmd.Parameters.AddWithValue("@Nom", lenom);
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

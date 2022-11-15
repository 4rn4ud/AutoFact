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

            Customer customer = new Customer(TxtCustName.Text.Trim(), TxtCustLastName.Text.Trim(), TxtCustCompany.Text.Trim(), Convert.ToInt32(TxtCustPostal.Text.Trim()), TxtCustAdress.Text.Trim(), TxtCustCity.Text.Trim(), TxtCustMail.Text.Trim(), Convert.ToInt32(TxtCustTel.Text.Trim()));
            if (customer.insert())
            {
                MessageBox.Show("Vous avez bien ajouté le produit.");
                TxtCustName.Clear();
                TxtCustLastName.Clear();
                TxtCustCompany.Clear();
                TxtCustPostal.Clear();
                TxtCustAdress.Clear();
                TxtCustCity.Clear();
                TxtCustMail.Clear();
                TxtCustTel.Clear();
            }
            else MessageBox.Show("Erreur.");

        }
        

        private void FormClientA_Load(object sender, EventArgs e)
        { 

        
        }
            
    }
}
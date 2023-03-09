using AutoFact.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact
{
    public partial class FormClientModif : Form
    {
        public FormClientModif()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            this.Hide();
            Menu.Show();
        }

        private void FormClientModif_Load(object sender, EventArgs e)
        {
            ListCustomers.DataSource = ManagerCustomers.getAllCustomer();
          
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ListCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] customers = ListCustomers.SelectedValue.ToString().Split(',');


            foreach (Customer theCustomer in ManagerCustomers.getAllCustomer())
            {
               
                if (theCustomer.getId() == Convert.ToInt32(customers[0]))
                {
                  
                    TxtCustName.Text = theCustomer.getName();
                    TxtCustLastName.Text = theCustomer.getLastname();
                    TxtCustCompany.Text = theCustomer.getCompanyName();
                    TxtCustPostal.Text = theCustomer.getPostalcode().ToString();
                    TxtCustAdress.Text = theCustomer.getAdress();
                    TxtCustCity.Text = theCustomer.getCity();                    
                    TxtCustMail.Text = theCustomer.getMail();
                    TxtCustTel.Text = theCustomer.getTel().ToString();
                }
                

            }
           
        }

        private void butModif_Click(object sender, EventArgs e)
        {
            string[] customers = ListCustomers.SelectedValue.ToString().Split(',');
            foreach (Customer theCustomer in ManagerCustomers.getAllCustomer())
            {

                if (theCustomer.getId() == Convert.ToInt32(customers[0]))
                {
                    theCustomer.setName(TxtCustName.Text);
                    theCustomer.setLastname(TxtCustLastName.Text);
                    theCustomer.setCompannyName(TxtCustCompany.Text);
                    theCustomer.setPostalcode(Convert.ToInt32(TxtCustPostal.Text));
                    theCustomer.setAdress(TxtCustAdress.Text);
                    theCustomer.setCity(TxtCustCity.Text);                                    
                    theCustomer.setMail(TxtCustMail.Text);                   
                    theCustomer.setTel(Convert.ToInt32(TxtCustTel.Text));
                    if (theCustomer.update())
                    {
                        this.Close();
                        MessageBox.Show("Vous avez bien modifié le client.");
                    }
                    else MessageBox.Show("Erreur.");
                }


            }

        }

        private void TxtCustTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Empêche la saisie de caractères autres que des chiffres
                e.Handled = true;
            }
        }

        private void TxtCustPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Empêche la saisie de caractères autres que des chiffres
                e.Handled = true;
            }
        }
    }
}

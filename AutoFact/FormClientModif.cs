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
            foreach(Customer aCustomer in ManagerCustomers.getAllCustomer())
            {
                if (aCustomer.getName() == "")
                {
                    ListCustomers.Items.Add(aCustomer.getCompanyName());
                    ListCustomers.Items.Add(aCustomer.getName() + " " + aCustomer.getLastname());

                }
                else ListCustomers.Items.Add(aCustomer.getName() + " " + aCustomer.getLastname());

            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Customer theCustomer in ManagerCustomers.getAllCustomer())
            {//Il faut recuperer l'id de la combobox
                if (theCustomer.getId() == ListCustomers.)
                {
                    TxtCustAdress.Text = theCustomer.getAdress();
                    TxtCustCity.Text = theCustomer.getCity();
                    TxtCustCompany.Text = theCustomer.getCompanyName();
                    TxtCustLastName.Text = theCustomer.getLastname();
                    TxtCustMail.Text = theCustomer.getMail();
                    TxtCustName.Text = theCustomer.getName();
                    TxtCustPostal.Text = theCustomer.getPostalcode().ToString();
                    TxtCustTel.Text = theCustomer.getTel().ToString();
                }
                

            }
           
        }
    }
}

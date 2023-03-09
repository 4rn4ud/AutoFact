using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AutoFact.Models;
using System.Data.Entity;

namespace AutoFact
{
    public partial class FormClientListage : Form
    {
       
        
        public FormClientListage()
        {
            InitializeComponent();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormClientV_Load(object sender, EventArgs e)
        {
            
            foreach (Customer unCustomer in ManagerCustomers.getAllCustomer())
            {
                dataGridViewCustomers.Rows.Add(unCustomer.getId(),unCustomer.getName(), unCustomer.getLastname(), unCustomer.getCompanyName(), unCustomer.getPostalcode(), unCustomer.getAdress(), unCustomer.getCity(), unCustomer.getMail(), unCustomer.getTel());
            }



        }

    }
}

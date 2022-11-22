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
    public partial class FormProdModif : Form
    {
        public FormProdModif()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void FormProdModif_Load(object sender, EventArgs e)
        {
            ListProduct.DataSource = ManagerProduct.getAllProduct();
        }
        public void ListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] theproduct = ListProduct.SelectedValue.ToString().Split(',');


            foreach (Product oneproduct in ManagerProduct.getAllProduct())
            {

                if (oneproduct.getId() == Convert.ToInt32(theproduct[0]))
                {

                    txtLibel.Text = oneproduct.getLibel();
                    txtPrice.Text = oneproduct.getUnitprice().ToString();
                  
                }


            }

        }

    }
}

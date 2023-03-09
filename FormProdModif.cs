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
      

        private void butModif_Click(object sender, EventArgs e)
        {
            string[] idproduct = ListProduct.SelectedValue.ToString().Split(',');
            foreach (Product theproduct in ManagerProduct.getAllProduct())
            {

                if (theproduct.getId() == Convert.ToInt32(idproduct[0]))
                {
                    theproduct.setLibel(txtLibel.Text);
                   
                    theproduct.setUnitprice(Convert.ToDouble(txtPrice.Text));
                   
                    if (theproduct.update())
                    {
                        this.Close();
                        MessageBox.Show("Vous avez bien modifié le produit.");
                    }
                    else MessageBox.Show("Erreur.");
                }


            }
        }

        private void ListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

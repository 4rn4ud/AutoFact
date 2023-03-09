using AutoFact.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace AutoFact
{
    public partial class FormDocAjt : Form
    {
        public FormDocAjt()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void FormDocAjt_Load(object sender, EventArgs e)
        {
            listCust.DataSource = ManagerCustomers.getAllCustomer();
            listType.DataSource = ManagerType.getAllType();
            
            foreach(Product p in ManagerProduct.getAllProduct())
            {
                colProd.Items.Add(p.ToString());
              
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
          
        }
        public void colProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void butCreate_Click(object sender, EventArgs e)

        {
            
            string[] customers = listCust.SelectedValue.ToString().Split(',');
            string[] type = listType.SelectedValue.ToString().Split(',');
            Quote thequote = new Quote(Convert.ToInt32(customers[0]));
            Status thestatus = new Status(datequote.Value, thequote.insert(), Convert.ToInt32(type[0]));
            if (thestatus.insert())
            {

            }
            else
            {
            }


            
            int nbligne = this.datainvoiceline.Rows.Count;           
            nbligne -= 1;
            for (int i = 0; i < nbligne; i++)
            {   
                string[] oneproduct = datainvoiceline.Rows[i].Cells[1].Value.ToString().Split(',');
                foreach (Product theproduct in ManagerProduct.getAllProduct())
                {
                    if(theproduct.getId() == Convert.ToInt32(oneproduct[0]))
                    {
                        Product theproductrows = theproduct;
                        Invoiceline theinvoiceline = new Invoiceline(theproductrows.getId(), thestatus.getidQuote(), Convert.ToInt32(datainvoiceline.Rows[i].Cells[0].Value), Convert.ToInt32(datainvoiceline.Rows[i].Cells[2].Value), theproductrows.getUnitprice());
                        
                        if (theinvoiceline.insert())
                        {

                        }
                        else
                        {
                            

                        }
                        MessageBox.Show("Votre facture est crée");
                    }


                }


            }





        }
        
        private void datainvoiceline_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void datainvoiceline_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        private void datainvoiceline_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Vérifiez si la colonne actuelle est la première ou la troisième colonne
            if (datainvoiceline.CurrentCell.ColumnIndex == 0 || datainvoiceline.CurrentCell.ColumnIndex == 2)
            {
                // Récupérez le contrôle de saisie actuel
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    // Attachez un gestionnaire d'événements à l'événement KeyPress
                    tb.KeyPress += new KeyPressEventHandler(AllowNumbersOnly);
                }
            }
        }
        private void AllowNumbersOnly(object sender, KeyPressEventArgs e)
        {
            // Vérifiez si la touche saisie est un chiffre ou la touche de suppression
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Empêche la saisie de caractères autres que des chiffres
            }
        }
    }

}
    


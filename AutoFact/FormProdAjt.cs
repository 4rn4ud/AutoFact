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

namespace AutoFact
{
    public partial class FormProdAjt : Form
    {
        public FormProdAjt()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            this.Hide();
            Menu.Show();
        }

        private void FormProdAjt_Load(object sender, EventArgs e)
        {

        }

        private void ButCreate_Click(object sender, EventArgs e)
        {
            Product product = new Product(textBoxLibel.Text, Convert.ToDouble(textBoxPrice.Text));
            if (product.insert())
            {
                MessageBox.Show("Vous avez bien ajouté le produit.");
                textBoxLibel.Clear();
                textBoxPrice.Clear();
            }
            else MessageBox.Show("Erreur.");
            
        }
    }
}

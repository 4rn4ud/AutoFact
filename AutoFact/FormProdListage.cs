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

namespace AutoFact
{
    public partial class FormProdListage : Form
    {
        public FormProdListage()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FormProdListage_Load(object sender, EventArgs e)
        {
            foreach (Product oneProduct in ManagerProduct.getAllProduct())
            {
                dataGridViewListeProd.Rows.Add(oneProduct.getId(), oneProduct.getLibel(), oneProduct.getUnitprice());
            }
        }

        private void dataGridViewListeProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

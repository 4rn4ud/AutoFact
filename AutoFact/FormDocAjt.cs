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
            colProd.DataSource = ManagerProduct.getAllProduct();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
          /*if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
           {
               object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
               if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
               {
                   ((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Add(value);
                   e.ThrowException = false;
               }
           }*/
        }
    }
}

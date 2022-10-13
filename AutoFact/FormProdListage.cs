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
            SQLiteConnection conn = new SQLiteConnection("DataSource = mydatabase.db");
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From product", conn);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            dataGridViewListeProd.DataSource = dset.Tables[0];
            conn.Close();
        }
    }
}

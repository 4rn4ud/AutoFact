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

namespace AutoFact
{
    public partial class FormClientListage : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        
        public FormClientListage()
        {
            InitializeComponent();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormClientV_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("DataSource = mydatabase.db");
            conn.Open(); 
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From customers", conn); 
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            dataGridViewCustomers.DataSource = dset.Tables[0];
            conn.Close();



        }

    }
}

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
    public partial class FormDocListage : Form
    {
        public FormDocListage()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            this.Hide();
            Menu.Show();
        }

        private void FormDocListage_Load(object sender, EventArgs e)
        {            
            SQLiteConnection conn = new SQLiteConnection("DataSource = mydatabase.db");
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select quote.id, idcustomers, type.libel from quote inner join status on quote.id = status.idquote inner JOIN type on type.id = status.idtype GROUP by quote.id having max(idtype)", conn);
                                                                       
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            dataGridQuot.DataSource = dset.Tables[0];
            conn.Close();
        }

        private void dataGridQuot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

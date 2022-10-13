using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
//using System.Windows.Forms;


namespace AutoFact
{
    public partial class FormClientAjt : Form
    {
        public FormClientAjt()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            this.Hide();
            Menu.Show();
        }

        private void WriteSQLite()
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            WriteSQLite();

        }

        private void FormClientA_Load(object sender, EventArgs e)
        { 

        
        }
            
    }
}
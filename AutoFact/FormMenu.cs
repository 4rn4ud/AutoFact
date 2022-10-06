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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void visualisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientV ClientV = new FormClientV();
            this.Hide();
            ClientV.Show();
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientA ClientA = new FormClientA();
            this.Hide();
            ClientA.Show();
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientM ClientM = new FormClientM();
            this.Hide();
            ClientM.Show();
        }
    }
}

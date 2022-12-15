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
    public partial class FormDocSuivis : Form
    {
        public FormDocSuivis()
        {
            InitializeComponent();
        }

        private void FormDocSuivis_Load(object sender, EventArgs e)
        {
            ListQuote.DataSource = ManagerStatus.getStatus();
           


        }
        public void ListQuote_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] thequoteid = ListQuote.SelectedValue.ToString().Split(',');

            foreach (Status onestatus in ManagerStatus.getStatus())
            {
                if (Convert.ToInt32(thequoteid[0]) == onestatus.getidQuote())
                {
                    boxOldStatus.Text = onestatus.getTypeLibel();
                }
            }

        }
    }
}

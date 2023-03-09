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
        string[] thequoteid;

        public FormDocSuivis()
        {

            InitializeComponent();
        }

        private void FormDocSuivis_Load(object sender, EventArgs e)
        {
            ListQuote.DataSource = ManagerStatus.getStatus();
            boxNewStatus.DataSource = ManagerType.getAllType();

        }
      
        


        private void boxOldStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListQuote_SelectedIndexChanged(object sender, EventArgs e)
        {
            thequoteid =  ListQuote.SelectedValue.ToString().Split(',');
            foreach (Status onestatus in ManagerStatus.getStatus())
            {
                if (Convert.ToInt32(thequoteid[0]) == onestatus.getidQuote())
                {
                    boxOldStatus.Text = onestatus.getTypeLibel();
                }

            }
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            string[] newtype = boxNewStatus.SelectedValue.ToString().Split(',');


          Status newstatus = new Status(DateupdateStatus.Value, Convert.ToInt32(thequoteid[0]), Convert.ToInt32(newtype[0]));
            if (newstatus.insert())
            {
                MessageBox.Show("L'état de votre facture n°" + newstatus.getidQuote() + " est bien passé en " + newstatus.getTypeLibel() + ".");

            }
            else 
            { 
                MessageBox.Show("Une erreur est survenu."); 
            }
            this.Close();


        }
    }
}

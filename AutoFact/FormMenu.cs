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


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnAffiClient(object sender, EventArgs e)
        {
            FormClientListage Clientlistage = new FormClientListage();
            Clientlistage.Show();
        }

        private void BtnModClient_Click(object sender, EventArgs e)
        {
            FormClientModif ClientModif = new FormClientModif(); 
            ClientModif.Show();
        }

        private void BtnAjtClient_Click(object sender, EventArgs e)
        {
            FormClientAjt ClientAjt = new FormClientAjt();
            ClientAjt.Show();
        }


        private void BtnAffProd_Click(object sender, EventArgs e)
        {
            FormProdListage ProdListage = new FormProdListage();
            ProdListage.Show();
        }

        private void BtnModifProd_Click(object sender, EventArgs e)
        {
            FormProdModif ProdModif = new FormProdModif();
            ProdModif.Show();
        }

        private void BtnAjtProd_Click(object sender, EventArgs e)
        {
            FormProdAjt ProdAjt = new FormProdAjt();
            ProdAjt.Show();

        }


        private void BtnAffDoc_Click(object sender, EventArgs e)
        {
            FormDocListage DocListage = new FormDocListage();
            DocListage.Show();
        }

        private void BtnModDoc_Click(object sender, EventArgs e)
        {
            FormDocModif DocModif = new FormDocModif();
            DocModif.Show();
        }

        private void BtnAjtDoc_Click(object sender, EventArgs e)
        {
            FormDocAjt DocAjt = new FormDocAjt();
            DocAjt.Show();
        }


        private void BtnVisuProf_Click(object sender, EventArgs e)
        {
            FormProfilAff ProfAff = new FormProfilAff();
            ProfAff.Show();
        }

        private void BtnModifProf_Click(object sender, EventArgs e)
        {
            FormProfilModif ProfModif = new FormProfilModif();
            ProfModif.Show();
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            FormInformationC InformationC = new FormInformationC();
            InformationC.Show();
        }
    }
}

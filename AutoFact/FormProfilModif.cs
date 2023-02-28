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
    public partial class FormProfilModif : Form
    {
        public FormProfilModif()
        {
            InitializeComponent();
        }

        private void FormProfilModif_Load(object sender, EventArgs e)
        {
            foreach (Profile oneprofile in ManagerProfile.getAllProfile())
            {
                if (oneprofile.getId() == 1)
                {
                    BoxAdress.Text = oneprofile.getAdress();
                    boxCity.Text = oneprofile.getCity();
                    boxCompName.Text = oneprofile.getcompanyname();
                    boxEmail.Text = oneprofile.getEmail();
                    boxPostalCode.Text = oneprofile.getPostalcode().ToString();
                    boxTel.Text = oneprofile.getTel().ToString();
                    BoxSiren.Text = oneprofile.getSiren().ToString();

                }

            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            foreach (Profile theprofile in ManagerProfile.getAllProfile())
            {
                if (theprofile.getId() == 1)
                {
                    theprofile.setTel(Convert.ToInt32(boxTel.Text));
                    theprofile.setPostalCode(Convert.ToInt32(boxPostalCode.Text));
                    theprofile.setSiren(Convert.ToInt32(BoxSiren.Text));
                    theprofile.setAdress(BoxAdress.Text);
                    theprofile.setCity(boxCity.Text);
                    theprofile.setCompanyname(boxCompName.Text);
                    theprofile.setEmail(boxEmail.Text);

                    if (theprofile.update())
                    {
                        this.Close();
                        MessageBox.Show("Vous avez bien modifié votre profile");

                    }
                    else MessageBox.Show("Erreur.");
                }

            }


        }

        private void boxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Empêche la saisie de caractères autres que des chiffres
                e.Handled = true;
            }
        }

        private void boxPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Empêche la saisie de caractères autres que des chiffres
                e.Handled = true;
            }
        }
    }
}

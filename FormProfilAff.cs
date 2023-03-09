using AutoFact.Models;
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
    public partial class FormProfilAff : Form
    {
        public FormProfilAff()
        {
            InitializeComponent();
        }

        private void FormProfilAff_Load(object sender, EventArgs e)
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

        private void boxCompName_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}

using AutoFact.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data. SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AutoFact
{
    public partial class FormDocListageAll : Form
    {
        public FormDocListageAll()
        {
            InitializeComponent();
        }

        private void FormDocListageAll_Load(object sender, EventArgs e)
        {
            foreach (Status onestatus in ManagerStatus.getAllStatus())
            {
                dataGridQuot.Rows.Add(onestatus.getidQuote(), onestatus.getTypeLibel(), onestatus.getDate());
                
            } 
                
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Action :";
                buttonColumn.Name = "PDFButton";
                buttonColumn.Text = "Génerer PDF";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridQuot.Columns.Add(buttonColumn);
               
                dataGridQuot.CellContentClick += dataGridView_CellContentClick;

                
        }

                public void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {


                }
    }
}

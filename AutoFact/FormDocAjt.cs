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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace AutoFact
{
    public partial class FormDocAjt : Form
    {
        public FormDocAjt()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void FormDocAjt_Load(object sender, EventArgs e)
        {
            listCust.DataSource = ManagerCustomers.getAllCustomer();
            listType.DataSource = ManagerType.getAllType();
            
            foreach(Product p in ManagerProduct.getAllProduct())
            {
                colProd.Items.Add(p.ToString());
              
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
          
        }
        public void colProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void butCreate_Click(object sender, EventArgs e)

        {
            string[] customers = listCust.SelectedValue.ToString().Split(',');
            Quote thequote = new Quote(Convert.ToInt32(customers[0]));
            if (thequote.insert())
            {

                MessageBox.Show("1 ok");

            }
            else MessageBox.Show("Vous n'avez pas reussie a crée la facture.");

            int nbligne = this.dataGridView1.Rows.Count;
            nbligne -= 1;


            //last_insert_rowid()
            using (SQLiteConnection conn = new SQLiteConnection("DataSource = ../../Resources/mydatabase.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {

                    conn.Open();
                    string strSql = "select last_insert_rowid(); ";                   
                    cmd.CommandText = strSql;
                    cmd.Connection = conn;
                    int dernierid = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(dernierid.ToString());



                }
            }
            
        }

    }





}
    


﻿using AutoFact.Models;
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
            foreach (Status onestatus in ManagerStatus.getStatus())
            {
                dataGridQuot.Rows.Add(onestatus.getidQuote(),  onestatus.getTypeLibel(), onestatus.getDate());
            }
        }

        private void dataGridQuot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
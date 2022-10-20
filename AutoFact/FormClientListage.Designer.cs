namespace AutoFact
{
    partial class FormClientListage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcompanyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colName,
            this.colLastName,
            this.colcompanyname,
            this.colPostalCode,
            this.colAdress,
            this.colCity,
            this.colMail,
            this.colTel});
            this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 192);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(949, 150);
            this.dataGridViewCustomers.TabIndex = 2;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colid
            // 
            this.colid.HeaderText = "Id";
            this.colid.Name = "colid";
            // 
            // colName
            // 
            this.colName.HeaderText = "Prénom";
            this.colName.Name = "colName";
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Nom de famille";
            this.colLastName.Name = "colLastName";
            // 
            // colcompanyname
            // 
            this.colcompanyname.HeaderText = "Raison Social";
            this.colcompanyname.Name = "colcompanyname";
            // 
            // colPostalCode
            // 
            this.colPostalCode.HeaderText = "Code Postal";
            this.colPostalCode.Name = "colPostalCode";
            // 
            // colAdress
            // 
            this.colAdress.HeaderText = "Adresse";
            this.colAdress.Name = "colAdress";
            // 
            // colCity
            // 
            this.colCity.HeaderText = "Ville";
            this.colCity.Name = "colCity";
            // 
            // colMail
            // 
            this.colMail.HeaderText = "Mail";
            this.colMail.Name = "colMail";
            // 
            // colTel
            // 
            this.colTel.HeaderText = "Téléphone";
            this.colTel.Name = "colTel";
            // 
            // FormClientListage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Name = "FormClientListage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormClientV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcompanyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
    }
}
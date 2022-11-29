namespace AutoFact
{
    partial class FormDocAjt
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
            this.components = new System.ComponentModel.Container();
            this.listCust = new System.Windows.Forms.ComboBox();
            this.LabCust = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.listType = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPromo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listCust
            // 
            this.listCust.FormattingEnabled = true;
            this.listCust.Location = new System.Drawing.Point(162, 104);
            this.listCust.Name = "listCust";
            this.listCust.Size = new System.Drawing.Size(121, 21);
            this.listCust.TabIndex = 0;
            // 
            // LabCust
            // 
            this.LabCust.AutoSize = true;
            this.LabCust.Location = new System.Drawing.Point(93, 112);
            this.LabCust.Name = "LabCust";
            this.LabCust.Size = new System.Drawing.Size(36, 13);
            this.LabCust.TabIndex = 3;
            this.LabCust.Text = "Client:";
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(407, 112);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(26, 13);
            this.labStatus.TabIndex = 4;
            this.labStatus.Text = "État";
            // 
            // listType
            // 
            this.listType.FormattingEnabled = true;
            this.listType.Location = new System.Drawing.Point(452, 104);
            this.listType.Name = "listType";
            this.listType.Size = new System.Drawing.Size(121, 21);
            this.listType.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuantity,
            this.colProd,
            this.colPromo});
            this.dataGridView1.Location = new System.Drawing.Point(195, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 205);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantité:";
            this.colQuantity.Name = "colQuantity";
            // 
            // colProd
            // 
            this.colProd.HeaderText = "Produit";
            this.colProd.Name = "colProd";
            // 
            // colPromo
            // 
            this.colPromo.HeaderText = "Promotion";
            this.colPromo.Name = "colPromo";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(AutoFact.Product);
            // 
            // FormDocAjt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listType);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.LabCust);
            this.Controls.Add(this.listCust);
            this.Name = "FormDocAjt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormDocAjt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listCust;
        private System.Windows.Forms.Label LabCust;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.ComboBox listType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromo;
    }
}
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
            this.datainvoiceline = new System.Windows.Forms.DataGridView();
            this.butCreate = new System.Windows.Forms.Button();
            this.datequote = new System.Windows.Forms.DateTimePicker();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPromo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datainvoiceline)).BeginInit();
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
            // datainvoiceline
            // 
            this.datainvoiceline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datainvoiceline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuantity,
            this.colProd,
            this.colPromo});
            this.datainvoiceline.Location = new System.Drawing.Point(162, 303);
            this.datainvoiceline.Name = "datainvoiceline";
            this.datainvoiceline.Size = new System.Drawing.Size(462, 205);
            this.datainvoiceline.TabIndex = 6;
            this.datainvoiceline.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.datainvoiceline.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.datainvoiceline.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.datainvoiceline_CellValidating);
            this.datainvoiceline.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.datainvoiceline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datainvoiceline_KeyPress);
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(712, 564);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(75, 23);
            this.butCreate.TabIndex = 7;
            this.butCreate.Text = "Créer";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // datequote
            // 
            this.datequote.Location = new System.Drawing.Point(96, 192);
            this.datequote.Name = "datequote";
            this.datequote.Size = new System.Drawing.Size(200, 20);
            this.datequote.TabIndex = 8;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(AutoFact.Product);
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
            this.colPromo.HeaderText = "Promotion:";
            this.colPromo.Name = "colPromo";
            // 
            // FormDocAjt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.datequote);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.datainvoiceline);
            this.Controls.Add(this.listType);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.LabCust);
            this.Controls.Add(this.listCust);
            this.Name = "FormDocAjt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormDocAjt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datainvoiceline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listCust;
        private System.Windows.Forms.Label LabCust;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.ComboBox listType;
        private System.Windows.Forms.DataGridView datainvoiceline;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.DateTimePicker datequote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromo;
    }
}
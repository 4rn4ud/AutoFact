namespace AutoFact
{
    partial class FormProdListage
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
            this.dataGridViewListeProd = new System.Windows.Forms.DataGridView();
            this.TitreListeProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListeProd
            // 
            this.dataGridViewListeProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeProd.Location = new System.Drawing.Point(211, 301);
            this.dataGridViewListeProd.Name = "dataGridViewListeProd";
            this.dataGridViewListeProd.Size = new System.Drawing.Size(365, 150);
            this.dataGridViewListeProd.TabIndex = 0;
            // 
            // TitreListeProd
            // 
            this.TitreListeProd.AutoSize = true;
            this.TitreListeProd.Location = new System.Drawing.Point(324, 263);
            this.TitreListeProd.Name = "TitreListeProd";
            this.TitreListeProd.Size = new System.Drawing.Size(119, 13);
            this.TitreListeProd.TabIndex = 1;
            this.TitreListeProd.Text = "La Liste de vos produits";
            // 
            // FormProdListage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.TitreListeProd);
            this.Controls.Add(this.dataGridViewListeProd);
            this.Name = "FormProdListage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormProdListage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListeProd;
        private System.Windows.Forms.Label TitreListeProd;
    }
}
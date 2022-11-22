namespace AutoFact
{
    partial class FormProdModif
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
            this.labLib = new System.Windows.Forms.Label();
            this.LabPrice = new System.Windows.Forms.Label();
            this.ListProduct = new System.Windows.Forms.ComboBox();
            this.LabChoice = new System.Windows.Forms.Label();
            this.txtLibel = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.butModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLib
            // 
            this.labLib.AutoSize = true;
            this.labLib.Location = new System.Drawing.Point(233, 213);
            this.labLib.Name = "labLib";
            this.labLib.Size = new System.Drawing.Size(83, 13);
            this.labLib.TabIndex = 0;
            this.labLib.Text = "Nouveau libellé:";
            // 
            // LabPrice
            // 
            this.LabPrice.AutoSize = true;
            this.LabPrice.Location = new System.Drawing.Point(233, 290);
            this.LabPrice.Name = "LabPrice";
            this.LabPrice.Size = new System.Drawing.Size(110, 13);
            this.LabPrice.TabIndex = 1;
            this.LabPrice.Text = "Nouveau prix unitaire:";
            // 
            // ListProduct
            // 
            this.ListProduct.FormattingEnabled = true;
            this.ListProduct.Location = new System.Drawing.Point(415, 108);
            this.ListProduct.Name = "ListProduct";
            this.ListProduct.Size = new System.Drawing.Size(121, 21);
            this.ListProduct.TabIndex = 2;
            // 
            // LabChoice
            // 
            this.LabChoice.AutoSize = true;
            this.LabChoice.Location = new System.Drawing.Point(233, 116);
            this.LabChoice.Name = "LabChoice";
            this.LabChoice.Size = new System.Drawing.Size(91, 13);
            this.LabChoice.TabIndex = 3;
            this.LabChoice.Text = "Produit à modifier:";
            // 
            // txtLibel
            // 
            this.txtLibel.Location = new System.Drawing.Point(415, 206);
            this.txtLibel.Name = "txtLibel";
            this.txtLibel.Size = new System.Drawing.Size(100, 20);
            this.txtLibel.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(415, 283);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // butModif
            // 
            this.butModif.Location = new System.Drawing.Point(593, 457);
            this.butModif.Name = "butModif";
            this.butModif.Size = new System.Drawing.Size(75, 23);
            this.butModif.TabIndex = 6;
            this.butModif.Text = "Modifier";
            this.butModif.UseVisualStyleBackColor = true;
            // 
            // FormProdModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.butModif);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtLibel);
            this.Controls.Add(this.LabChoice);
            this.Controls.Add(this.ListProduct);
            this.Controls.Add(this.LabPrice);
            this.Controls.Add(this.labLib);
            this.Name = "FormProdModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormProdModif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLib;
        private System.Windows.Forms.Label LabPrice;
        private System.Windows.Forms.ComboBox ListProduct;
        private System.Windows.Forms.Label LabChoice;
        private System.Windows.Forms.TextBox txtLibel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button butModif;
    }
}
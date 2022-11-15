namespace AutoFact
{
    partial class FormProdAjt
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
            this.ButCreate = new System.Windows.Forms.Button();
            this.LabLibel = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.textBoxLibel = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButCreate
            // 
            this.ButCreate.Location = new System.Drawing.Point(595, 515);
            this.ButCreate.Name = "ButCreate";
            this.ButCreate.Size = new System.Drawing.Size(75, 23);
            this.ButCreate.TabIndex = 0;
            this.ButCreate.Text = "Ajouter";
            this.ButCreate.UseVisualStyleBackColor = true;
            this.ButCreate.Click += new System.EventHandler(this.ButCreate_Click);
            // 
            // LabLibel
            // 
            this.LabLibel.AutoSize = true;
            this.LabLibel.Location = new System.Drawing.Point(300, 300);
            this.LabLibel.Name = "LabLibel";
            this.LabLibel.Size = new System.Drawing.Size(40, 13);
            this.LabLibel.TabIndex = 3;
            this.LabLibel.Text = "Libellé:";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(300, 350);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(64, 13);
            this.labPrice.TabIndex = 4;
            this.labPrice.Text = "Prix unitaire:";
            // 
            // textBoxLibel
            // 
            this.textBoxLibel.Location = new System.Drawing.Point(455, 300);
            this.textBoxLibel.Name = "textBoxLibel";
            this.textBoxLibel.Size = new System.Drawing.Size(100, 20);
            this.textBoxLibel.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(455, 350);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 8;
            // 
            // FormProdAjt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxLibel);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.LabLibel);
            this.Controls.Add(this.ButCreate);
            this.Name = "FormProdAjt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormProdAjt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButCreate;
        private System.Windows.Forms.Label LabLibel;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.TextBox textBoxLibel;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}
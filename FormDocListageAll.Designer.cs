namespace AutoFact
{
    partial class FormDocListageAll
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
            this.dataGridQuot = new System.Windows.Forms.DataGridView();
            this.colidquote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colidtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuot)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQuot
            // 
            this.dataGridQuot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colidquote,
            this.colidtype,
            this.coddate});
            this.dataGridQuot.Location = new System.Drawing.Point(106, 150);
            this.dataGridQuot.Name = "dataGridQuot";
            this.dataGridQuot.Size = new System.Drawing.Size(589, 150);
            this.dataGridQuot.TabIndex = 1;
            this.dataGridQuot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQuot_CellContentClick);
            // 
            // colidquote
            // 
            this.colidquote.HeaderText = "Numéro de facture:";
            this.colidquote.Name = "colidquote";
            // 
            // colidtype
            // 
            this.colidtype.HeaderText = "État de la facture:";
            this.colidtype.Name = "colidtype";
            // 
            // coddate
            // 
            this.coddate.HeaderText = "Date:";
            this.coddate.Name = "coddate";
            // 
            // FormDocListageAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridQuot);
            this.Name = "FormDocListageAll";
            this.Text = "FormDocListageAll";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridQuot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidquote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddate;
    }
}
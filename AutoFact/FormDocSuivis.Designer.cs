namespace AutoFact
{
    partial class FormDocSuivis
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
            this.ListQuote = new System.Windows.Forms.ComboBox();
            this.labQuote = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labOldStatus = new System.Windows.Forms.Label();
            this.labNewStatus = new System.Windows.Forms.Label();
            this.butChange = new System.Windows.Forms.Button();
            this.boxOldStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListQuote
            // 
            this.ListQuote.FormattingEnabled = true;
            this.ListQuote.Location = new System.Drawing.Point(210, 213);
            this.ListQuote.Name = "ListQuote";
            this.ListQuote.Size = new System.Drawing.Size(121, 21);
            this.ListQuote.TabIndex = 0;
            // 
            // labQuote
            // 
            this.labQuote.AutoSize = true;
            this.labQuote.Location = new System.Drawing.Point(124, 213);
            this.labQuote.Name = "labQuote";
            this.labQuote.Size = new System.Drawing.Size(59, 13);
            this.labQuote.TabIndex = 1;
            this.labQuote.Text = "Document:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(510, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(210, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // labOldStatus
            // 
            this.labOldStatus.AutoSize = true;
            this.labOldStatus.Location = new System.Drawing.Point(124, 273);
            this.labOldStatus.Name = "labOldStatus";
            this.labOldStatus.Size = new System.Drawing.Size(64, 13);
            this.labOldStatus.TabIndex = 4;
            this.labOldStatus.Text = "Ancien état:";
            // 
            // labNewStatus
            // 
            this.labNewStatus.AutoSize = true;
            this.labNewStatus.Location = new System.Drawing.Point(124, 334);
            this.labNewStatus.Name = "labNewStatus";
            this.labNewStatus.Size = new System.Drawing.Size(65, 13);
            this.labNewStatus.TabIndex = 6;
            this.labNewStatus.Text = "Nouvel état:";
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(442, 364);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(75, 23);
            this.butChange.TabIndex = 7;
            this.butChange.Text = "Changer";
            this.butChange.UseVisualStyleBackColor = true;
            // 
            // boxOldStatus
            // 
            this.boxOldStatus.Enabled = false;
            this.boxOldStatus.Location = new System.Drawing.Point(210, 273);
            this.boxOldStatus.Name = "boxOldStatus";
            this.boxOldStatus.ReadOnly = true;
            this.boxOldStatus.Size = new System.Drawing.Size(121, 20);
            this.boxOldStatus.TabIndex = 14;
            // 
            // FormDocSuivis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxOldStatus);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.labNewStatus);
            this.Controls.Add(this.labOldStatus);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labQuote);
            this.Controls.Add(this.ListQuote);
            this.Name = "FormDocSuivis";
            this.Text = "FormDocSuivis";
            this.Load += new System.EventHandler(this.FormDocSuivis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListQuote;
        private System.Windows.Forms.Label labQuote;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labOldStatus;
        private System.Windows.Forms.Label labNewStatus;
        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.TextBox boxOldStatus;
    }
}
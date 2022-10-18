namespace AutoFact
{
    partial class FormClientAjt
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
            this.btnAddCust = new System.Windows.Forms.Button();
            this.TxtCustAdress = new System.Windows.Forms.TextBox();
            this.TxtCustCity = new System.Windows.Forms.TextBox();
            this.TxtCustName = new System.Windows.Forms.TextBox();
            this.TxtCustLastName = new System.Windows.Forms.TextBox();
            this.TxtCustCompany = new System.Windows.Forms.TextBox();
            this.TxtCustPostal = new System.Windows.Forms.TextBox();
            this.TxtCustTel = new System.Windows.Forms.TextBox();
            this.TxtCustMail = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.companyname = new System.Windows.Forms.Label();
            this.postalcode = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(517, 373);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(56, 19);
            this.btnAddCust.TabIndex = 3;
            this.btnAddCust.Text = "ajouter";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.butAddCust_Click);
            // 
            // TxtCustAdress
            // 
            this.TxtCustAdress.Location = new System.Drawing.Point(455, 130);
            this.TxtCustAdress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustAdress.Name = "TxtCustAdress";
            this.TxtCustAdress.Size = new System.Drawing.Size(76, 20);
            this.TxtCustAdress.TabIndex = 4;
            // 
            // TxtCustCity
            // 
            this.TxtCustCity.Location = new System.Drawing.Point(455, 190);
            this.TxtCustCity.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustCity.Name = "TxtCustCity";
            this.TxtCustCity.Size = new System.Drawing.Size(76, 20);
            this.TxtCustCity.TabIndex = 5;
            // 
            // TxtCustName
            // 
            this.TxtCustName.Location = new System.Drawing.Point(208, 130);
            this.TxtCustName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustName.Name = "TxtCustName";
            this.TxtCustName.Size = new System.Drawing.Size(76, 20);
            this.TxtCustName.TabIndex = 6;
            // 
            // TxtCustLastName
            // 
            this.TxtCustLastName.Location = new System.Drawing.Point(208, 190);
            this.TxtCustLastName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustLastName.Name = "TxtCustLastName";
            this.TxtCustLastName.Size = new System.Drawing.Size(76, 20);
            this.TxtCustLastName.TabIndex = 7;
            // 
            // TxtCustCompany
            // 
            this.TxtCustCompany.Location = new System.Drawing.Point(208, 248);
            this.TxtCustCompany.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustCompany.Name = "TxtCustCompany";
            this.TxtCustCompany.Size = new System.Drawing.Size(76, 20);
            this.TxtCustCompany.TabIndex = 8;
            // 
            // TxtCustPostal
            // 
            this.TxtCustPostal.Location = new System.Drawing.Point(208, 310);
            this.TxtCustPostal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustPostal.Name = "TxtCustPostal";
            this.TxtCustPostal.Size = new System.Drawing.Size(76, 20);
            this.TxtCustPostal.TabIndex = 9;
            // 
            // TxtCustTel
            // 
            this.TxtCustTel.Location = new System.Drawing.Point(455, 310);
            this.TxtCustTel.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustTel.Name = "TxtCustTel";
            this.TxtCustTel.Size = new System.Drawing.Size(76, 20);
            this.TxtCustTel.TabIndex = 10;
            // 
            // TxtCustMail
            // 
            this.TxtCustMail.Location = new System.Drawing.Point(455, 248);
            this.TxtCustMail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustMail.Name = "TxtCustMail";
            this.TxtCustMail.Size = new System.Drawing.Size(76, 20);
            this.TxtCustMail.TabIndex = 11;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(97, 193);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(32, 13);
            this.lastname.TabIndex = 12;
            this.lastname.Text = "Nom:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(97, 133);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 13);
            this.name.TabIndex = 13;
            this.name.Text = "Prénom:";
            // 
            // companyname
            // 
            this.companyname.AutoSize = true;
            this.companyname.Location = new System.Drawing.Point(97, 251);
            this.companyname.Name = "companyname";
            this.companyname.Size = new System.Drawing.Size(78, 13);
            this.companyname.TabIndex = 14;
            this.companyname.Text = "RaisonSociale:";
            // 
            // postalcode
            // 
            this.postalcode.AutoSize = true;
            this.postalcode.Location = new System.Drawing.Point(97, 313);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(67, 13);
            this.postalcode.TabIndex = 15;
            this.postalcode.Text = "Code Postal:";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(317, 133);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(48, 13);
            this.adress.TabIndex = 16;
            this.adress.Text = "Adresse:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(317, 193);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(27, 13);
            this.city.TabIndex = 17;
            this.city.Text = "Vile:";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(317, 251);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(29, 13);
            this.mail.TabIndex = 18;
            this.mail.Text = "Mail:";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(317, 317);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(61, 13);
            this.tel.TabIndex = 19;
            this.tel.Text = "Téléphone:";
            // 
            // FormClientAjt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.city);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.postalcode);
            this.Controls.Add(this.companyname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.TxtCustMail);
            this.Controls.Add(this.TxtCustTel);
            this.Controls.Add(this.TxtCustPostal);
            this.Controls.Add(this.TxtCustCompany);
            this.Controls.Add(this.TxtCustLastName);
            this.Controls.Add(this.TxtCustName);
            this.Controls.Add(this.TxtCustCity);
            this.Controls.Add(this.TxtCustAdress);
            this.Controls.Add(this.btnAddCust);
            this.Name = "FormClientAjt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormClientA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.TextBox TxtCustAdress;
        private System.Windows.Forms.TextBox TxtCustCity;
        private System.Windows.Forms.TextBox TxtCustName;
        private System.Windows.Forms.TextBox TxtCustLastName;
        private System.Windows.Forms.TextBox TxtCustCompany;
        private System.Windows.Forms.TextBox TxtCustPostal;
        private System.Windows.Forms.TextBox TxtCustTel;
        private System.Windows.Forms.TextBox TxtCustMail;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label companyname;
        private System.Windows.Forms.Label postalcode;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label tel;
    }
}
namespace AutoFact
{
    partial class FormClientModif
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
            this.ListCustomers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.postalcode = new System.Windows.Forms.Label();
            this.companyname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.TxtCustMail = new System.Windows.Forms.TextBox();
            this.TxtCustTel = new System.Windows.Forms.TextBox();
            this.TxtCustPostal = new System.Windows.Forms.TextBox();
            this.TxtCustCompany = new System.Windows.Forms.TextBox();
            this.TxtCustLastName = new System.Windows.Forms.TextBox();
            this.TxtCustName = new System.Windows.Forms.TextBox();
            this.TxtCustCity = new System.Windows.Forms.TextBox();
            this.TxtCustAdress = new System.Windows.Forms.TextBox();
            this.butModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListCustomers
            // 
            this.ListCustomers.FormattingEnabled = true;
            this.ListCustomers.Location = new System.Drawing.Point(266, 120);
            this.ListCustomers.Name = "ListCustomers";
            this.ListCustomers.Size = new System.Drawing.Size(121, 21);
            this.ListCustomers.TabIndex = 0;
            this.ListCustomers.SelectedIndexChanged += new System.EventHandler(this.ListCustomers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "client:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(392, 418);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(61, 13);
            this.tel.TabIndex = 35;
            this.tel.Text = "Téléphone:";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(392, 352);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(29, 13);
            this.mail.TabIndex = 34;
            this.mail.Text = "Mail:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(392, 294);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(27, 13);
            this.city.TabIndex = 33;
            this.city.Text = "Vile:";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(392, 234);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(48, 13);
            this.adress.TabIndex = 32;
            this.adress.Text = "Adresse:";
            // 
            // postalcode
            // 
            this.postalcode.AutoSize = true;
            this.postalcode.Location = new System.Drawing.Point(172, 414);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(67, 13);
            this.postalcode.TabIndex = 31;
            this.postalcode.Text = "Code Postal:";
            // 
            // companyname
            // 
            this.companyname.AutoSize = true;
            this.companyname.Location = new System.Drawing.Point(172, 352);
            this.companyname.Name = "companyname";
            this.companyname.Size = new System.Drawing.Size(78, 13);
            this.companyname.TabIndex = 30;
            this.companyname.Text = "RaisonSociale:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(172, 234);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 13);
            this.name.TabIndex = 29;
            this.name.Text = "Prénom:";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(172, 294);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(32, 13);
            this.lastname.TabIndex = 28;
            this.lastname.Text = "Nom:";
            // 
            // TxtCustMail
            // 
            this.TxtCustMail.Location = new System.Drawing.Point(530, 349);
            this.TxtCustMail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustMail.Name = "TxtCustMail";
            this.TxtCustMail.Size = new System.Drawing.Size(76, 20);
            this.TxtCustMail.TabIndex = 27;
            // 
            // TxtCustTel
            // 
            this.TxtCustTel.Location = new System.Drawing.Point(530, 411);
            this.TxtCustTel.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustTel.Name = "TxtCustTel";
            this.TxtCustTel.Size = new System.Drawing.Size(76, 20);
            this.TxtCustTel.TabIndex = 26;
            // 
            // TxtCustPostal
            // 
            this.TxtCustPostal.Location = new System.Drawing.Point(283, 411);
            this.TxtCustPostal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustPostal.Name = "TxtCustPostal";
            this.TxtCustPostal.Size = new System.Drawing.Size(76, 20);
            this.TxtCustPostal.TabIndex = 25;
            // 
            // TxtCustCompany
            // 
            this.TxtCustCompany.Location = new System.Drawing.Point(283, 349);
            this.TxtCustCompany.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustCompany.Name = "TxtCustCompany";
            this.TxtCustCompany.Size = new System.Drawing.Size(76, 20);
            this.TxtCustCompany.TabIndex = 24;
            // 
            // TxtCustLastName
            // 
            this.TxtCustLastName.Location = new System.Drawing.Point(283, 291);
            this.TxtCustLastName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustLastName.Name = "TxtCustLastName";
            this.TxtCustLastName.Size = new System.Drawing.Size(76, 20);
            this.TxtCustLastName.TabIndex = 23;
            // 
            // TxtCustName
            // 
            this.TxtCustName.Location = new System.Drawing.Point(283, 231);
            this.TxtCustName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustName.Name = "TxtCustName";
            this.TxtCustName.Size = new System.Drawing.Size(76, 20);
            this.TxtCustName.TabIndex = 22;
            // 
            // TxtCustCity
            // 
            this.TxtCustCity.Location = new System.Drawing.Point(530, 291);
            this.TxtCustCity.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustCity.Name = "TxtCustCity";
            this.TxtCustCity.Size = new System.Drawing.Size(76, 20);
            this.TxtCustCity.TabIndex = 21;
            // 
            // TxtCustAdress
            // 
            this.TxtCustAdress.Location = new System.Drawing.Point(530, 231);
            this.TxtCustAdress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustAdress.Name = "TxtCustAdress";
            this.TxtCustAdress.Size = new System.Drawing.Size(76, 20);
            this.TxtCustAdress.TabIndex = 20;
            // 
            // butModif
            // 
            this.butModif.Location = new System.Drawing.Point(614, 533);
            this.butModif.Name = "butModif";
            this.butModif.Size = new System.Drawing.Size(75, 23);
            this.butModif.TabIndex = 36;
            this.butModif.Text = "Modifier";
            this.butModif.UseVisualStyleBackColor = true;
            this.butModif.Click += new System.EventHandler(this.butModif_Click);
            // 
            // FormClientModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.butModif);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListCustomers);
            this.Name = "FormClientModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormClientModif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label postalcode;
        private System.Windows.Forms.Label companyname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox TxtCustMail;
        private System.Windows.Forms.TextBox TxtCustTel;
        private System.Windows.Forms.TextBox TxtCustPostal;
        private System.Windows.Forms.TextBox TxtCustCompany;
        private System.Windows.Forms.TextBox TxtCustLastName;
        private System.Windows.Forms.TextBox TxtCustName;
        private System.Windows.Forms.TextBox TxtCustCity;
        private System.Windows.Forms.TextBox TxtCustAdress;
        private System.Windows.Forms.Button butModif;
    }
}
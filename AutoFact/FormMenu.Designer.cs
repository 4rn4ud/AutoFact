
namespace AutoFact
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnProfVisua = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnProfModif = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnModClient = new System.Windows.Forms.Button();
            this.BtnAjtClient = new System.Windows.Forms.Button();
            this.BtnAffProd = new System.Windows.Forms.Button();
            this.BtnModifProd = new System.Windows.Forms.Button();
            this.BtnAffDoc = new System.Windows.Forms.Button();
            this.BtnModDoc = new System.Windows.Forms.Button();
            this.BtnAjtProd = new System.Windows.Forms.Button();
            this.BtnAjtDoc = new System.Windows.Forms.Button();
            this.BtnVisuProf = new System.Windows.Forms.Button();
            this.BtnModifProf = new System.Windows.Forms.Button();
            this.BtnInformation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenue, sur votre logiciel préféré";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 245);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnProfVisua
            // 
            this.BtnProfVisua.Name = "BtnProfVisua";
            this.BtnProfVisua.Size = new System.Drawing.Size(32, 19);
            // 
            // BtnProfModif
            // 
            this.BtnProfModif.Name = "BtnProfModif";
            this.BtnProfModif.Size = new System.Drawing.Size(180, 22);
            this.BtnProfModif.Text = "Modification";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Liste des clients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnAffiClient);
            // 
            // BtnModClient
            // 
            this.BtnModClient.Location = new System.Drawing.Point(85, 194);
            this.BtnModClient.Name = "BtnModClient";
            this.BtnModClient.Size = new System.Drawing.Size(122, 23);
            this.BtnModClient.TabIndex = 6;
            this.BtnModClient.Text = "Modifier un client";
            this.BtnModClient.UseVisualStyleBackColor = true;
            this.BtnModClient.Click += new System.EventHandler(this.BtnModClient_Click);
            // 
            // BtnAjtClient
            // 
            this.BtnAjtClient.Location = new System.Drawing.Point(85, 249);
            this.BtnAjtClient.Name = "BtnAjtClient";
            this.BtnAjtClient.Size = new System.Drawing.Size(122, 23);
            this.BtnAjtClient.TabIndex = 7;
            this.BtnAjtClient.Text = "Ajouter un client";
            this.BtnAjtClient.UseVisualStyleBackColor = true;
            this.BtnAjtClient.Click += new System.EventHandler(this.BtnAjtClient_Click);
            // 
            // BtnAffProd
            // 
            this.BtnAffProd.Location = new System.Drawing.Point(85, 304);
            this.BtnAffProd.Name = "BtnAffProd";
            this.BtnAffProd.Size = new System.Drawing.Size(122, 23);
            this.BtnAffProd.TabIndex = 9;
            this.BtnAffProd.Text = "Liste des produits";
            this.BtnAffProd.UseVisualStyleBackColor = true;
            this.BtnAffProd.Click += new System.EventHandler(this.BtnAffProd_Click);
            // 
            // BtnModifProd
            // 
            this.BtnModifProd.Location = new System.Drawing.Point(85, 368);
            this.BtnModifProd.Name = "BtnModifProd";
            this.BtnModifProd.Size = new System.Drawing.Size(122, 23);
            this.BtnModifProd.TabIndex = 10;
            this.BtnModifProd.Text = "Modifier un produit";
            this.BtnModifProd.UseVisualStyleBackColor = true;
            this.BtnModifProd.Click += new System.EventHandler(this.BtnModifProd_Click);
            // 
            // BtnAffDoc
            // 
            this.BtnAffDoc.Location = new System.Drawing.Point(856, 146);
            this.BtnAffDoc.Name = "BtnAffDoc";
            this.BtnAffDoc.Size = new System.Drawing.Size(122, 23);
            this.BtnAffDoc.TabIndex = 12;
            this.BtnAffDoc.Text = "Liste des factures";
            this.BtnAffDoc.UseVisualStyleBackColor = true;
            this.BtnAffDoc.Click += new System.EventHandler(this.BtnAffDoc_Click);
            // 
            // BtnModDoc
            // 
            this.BtnModDoc.Location = new System.Drawing.Point(856, 194);
            this.BtnModDoc.Name = "BtnModDoc";
            this.BtnModDoc.Size = new System.Drawing.Size(122, 23);
            this.BtnModDoc.TabIndex = 13;
            this.BtnModDoc.Text = "Modifier une facture";
            this.BtnModDoc.UseVisualStyleBackColor = true;
            this.BtnModDoc.Click += new System.EventHandler(this.BtnModDoc_Click);
            // 
            // BtnAjtProd
            // 
            this.BtnAjtProd.Location = new System.Drawing.Point(85, 430);
            this.BtnAjtProd.Name = "BtnAjtProd";
            this.BtnAjtProd.Size = new System.Drawing.Size(122, 23);
            this.BtnAjtProd.TabIndex = 15;
            this.BtnAjtProd.Text = "Ajouter un produit";
            this.BtnAjtProd.UseVisualStyleBackColor = true;
            this.BtnAjtProd.Click += new System.EventHandler(this.BtnAjtProd_Click);
            // 
            // BtnAjtDoc
            // 
            this.BtnAjtDoc.Location = new System.Drawing.Point(856, 249);
            this.BtnAjtDoc.Name = "BtnAjtDoc";
            this.BtnAjtDoc.Size = new System.Drawing.Size(122, 23);
            this.BtnAjtDoc.TabIndex = 16;
            this.BtnAjtDoc.Text = "Créer une facture";
            this.BtnAjtDoc.UseVisualStyleBackColor = true;
            this.BtnAjtDoc.Click += new System.EventHandler(this.BtnAjtDoc_Click);
            // 
            // BtnVisuProf
            // 
            this.BtnVisuProf.Location = new System.Drawing.Point(856, 304);
            this.BtnVisuProf.Name = "BtnVisuProf";
            this.BtnVisuProf.Size = new System.Drawing.Size(122, 23);
            this.BtnVisuProf.TabIndex = 17;
            this.BtnVisuProf.Text = "Visualiser mon profil";
            this.BtnVisuProf.UseVisualStyleBackColor = true;
            this.BtnVisuProf.Click += new System.EventHandler(this.BtnVisuProf_Click);
            // 
            // BtnModifProf
            // 
            this.BtnModifProf.Location = new System.Drawing.Point(856, 368);
            this.BtnModifProf.Name = "BtnModifProf";
            this.BtnModifProf.Size = new System.Drawing.Size(122, 23);
            this.BtnModifProf.TabIndex = 18;
            this.BtnModifProf.Text = "Modifier mon profil";
            this.BtnModifProf.UseVisualStyleBackColor = true;
            this.BtnModifProf.Click += new System.EventHandler(this.BtnModifProf_Click);
            // 
            // BtnInformation
            // 
            this.BtnInformation.Location = new System.Drawing.Point(856, 421);
            this.BtnInformation.Name = "BtnInformation";
            this.BtnInformation.Size = new System.Drawing.Size(122, 23);
            this.BtnInformation.TabIndex = 19;
            this.BtnInformation.Text = "Information Comptable";
            this.BtnInformation.UseVisualStyleBackColor = true;
            this.BtnInformation.Click += new System.EventHandler(this.BtnInformation_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.BtnInformation);
            this.Controls.Add(this.BtnModifProf);
            this.Controls.Add(this.BtnVisuProf);
            this.Controls.Add(this.BtnAjtDoc);
            this.Controls.Add(this.BtnAjtProd);
            this.Controls.Add(this.BtnModDoc);
            this.Controls.Add(this.BtnAffDoc);
            this.Controls.Add(this.BtnModifProd);
            this.Controls.Add(this.BtnAffProd);
            this.Controls.Add(this.BtnAjtClient);
            this.Controls.Add(this.BtnModClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem BtnProfVisua;
        private System.Windows.Forms.ToolStripMenuItem BtnProfModif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnModClient;
        private System.Windows.Forms.Button BtnAjtClient;
        private System.Windows.Forms.Button BtnAffProd;
        private System.Windows.Forms.Button BtnModifProd;
        private System.Windows.Forms.Button BtnAffDoc;
        private System.Windows.Forms.Button BtnModDoc;
        private System.Windows.Forms.Button BtnAjtProd;
        private System.Windows.Forms.Button BtnAjtDoc;
        private System.Windows.Forms.Button BtnVisuProf;
        private System.Windows.Forms.Button BtnModifProf;
        private System.Windows.Forms.Button BtnInformation;
    }
}


namespace Student
{
    partial class Students
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.txtEcole = new System.Windows.Forms.TextBox();
            this.lblEcole = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtNaissance = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 172);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(16, 250);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.SpringGreen;
            this.btnValider.Location = new System.Drawing.Point(104, 528);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(192, 71);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(20, 282);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(317, 47);
            this.txtNom.TabIndex = 3;
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(20, 366);
            this.txtMatricule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatricule.Multiline = true;
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(317, 45);
            this.txtMatricule.TabIndex = 5;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(16, 334);
            this.lblMatricule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(65, 17);
            this.lblMatricule.TabIndex = 4;
            this.lblMatricule.Text = "Matricule";
            // 
            // txtEcole
            // 
            this.txtEcole.Location = new System.Drawing.Point(20, 447);
            this.txtEcole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEcole.Multiline = true;
            this.txtEcole.Name = "txtEcole";
            this.txtEcole.Size = new System.Drawing.Size(317, 43);
            this.txtEcole.TabIndex = 7;
            // 
            // lblEcole
            // 
            this.lblEcole.AutoSize = true;
            this.lblEcole.Location = new System.Drawing.Point(16, 415);
            this.lblEcole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEcole.Name = "lblEcole";
            this.lblEcole.Size = new System.Drawing.Size(43, 17);
            this.lblEcole.TabIndex = 6;
            this.lblEcole.Text = "Ecole";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnnuler.Location = new System.Drawing.Point(325, 528);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(173, 71);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(423, 447);
            this.txtVille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVille.Multiline = true;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(317, 43);
            this.txtVille.TabIndex = 11;
            // 
            // txtNaissance
            // 
            this.txtNaissance.Location = new System.Drawing.Point(423, 366);
            this.txtNaissance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNaissance.Multiline = true;
            this.txtNaissance.Name = "txtNaissance";
            this.txtNaissance.Size = new System.Drawing.Size(317, 45);
            this.txtNaissance.TabIndex = 10;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(423, 282);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(317, 47);
            this.txtPrenom.TabIndex = 9;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(419, 262);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 12;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.Location = new System.Drawing.Point(419, 346);
            this.lblNaissance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(128, 17);
            this.lblNaissance.TabIndex = 13;
            this.lblNaissance.Text = "Date de Naissance";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(419, 427);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(34, 17);
            this.lblVille.TabIndex = 14;
            this.lblVille.Text = "Ville";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFermer.Location = new System.Drawing.Point(527, 528);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(173, 71);
            this.btnFermer.TabIndex = 15;
            this.btnFermer.Text = "Retour";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 655);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblNaissance);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtNaissance);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtEcole);
            this.Controls.Add(this.lblEcole);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eleve";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.TextBox txtEcole;
        private System.Windows.Forms.Label lblEcole;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtNaissance;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Button btnFermer;
    }
}


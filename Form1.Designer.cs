namespace Gestion_de_dvd
{
    partial class Form1
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
            this.lstDvd = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjoutDvd = new System.Windows.Forms.Button();
            this.btnSupprDvd = new System.Windows.Forms.Button();
            this.btnModifDvd = new System.Windows.Forms.Button();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDurée = new System.Windows.Forms.TextBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSupprGenre = new System.Windows.Forms.Button();
            this.btnAjoutGenre = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstActeur = new System.Windows.Forms.ListBox();
            this.btnAjoutActeurDvd = new System.Windows.Forms.Button();
            this.btnSupprActeurDvd = new System.Windows.Forms.Button();
            this.cboActeur = new System.Windows.Forms.ComboBox();
            this.txtAjoutActeur = new System.Windows.Forms.TextBox();
            this.btnSupprActeur = new System.Windows.Forms.Button();
            this.btnAjoutActeur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDvd
            // 
            this.lstDvd.FormattingEnabled = true;
            this.lstDvd.ItemHeight = 16;
            this.lstDvd.Location = new System.Drawing.Point(12, 39);
            this.lstDvd.Name = "lstDvd";
            this.lstDvd.Size = new System.Drawing.Size(220, 340);
            this.lstDvd.TabIndex = 0;
            this.lstDvd.SelectedIndexChanged += new System.EventHandler(this.lstDvd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des DVD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAjoutDvd
            // 
            this.btnAjoutDvd.Location = new System.Drawing.Point(251, 26);
            this.btnAjoutDvd.Name = "btnAjoutDvd";
            this.btnAjoutDvd.Size = new System.Drawing.Size(87, 23);
            this.btnAjoutDvd.TabIndex = 2;
            this.btnAjoutDvd.Text = "Ajout Dvd ( sans les acteurs ) ";
            this.btnAjoutDvd.UseVisualStyleBackColor = true;
            this.btnAjoutDvd.Click += new System.EventHandler(this.btnAjoutDvd_Click);
            // 
            // btnSupprDvd
            // 
            this.btnSupprDvd.Location = new System.Drawing.Point(251, 67);
            this.btnSupprDvd.Name = "btnSupprDvd";
            this.btnSupprDvd.Size = new System.Drawing.Size(87, 23);
            this.btnSupprDvd.TabIndex = 3;
            this.btnSupprDvd.Text = "Suppr Dvd";
            this.btnSupprDvd.UseVisualStyleBackColor = true;
            this.btnSupprDvd.Click += new System.EventHandler(this.btnSupprDvd_Click);
            // 
            // btnModifDvd
            // 
            this.btnModifDvd.Location = new System.Drawing.Point(251, 109);
            this.btnModifDvd.Name = "btnModifDvd";
            this.btnModifDvd.Size = new System.Drawing.Size(87, 23);
            this.btnModifDvd.TabIndex = 4;
            this.btnModifDvd.Text = "Modf (titre durée genre)";
            this.btnModifDvd.UseVisualStyleBackColor = true;
            this.btnModifDvd.Click += new System.EventHandler(this.btnModifDvd_Click);
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(455, 29);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(333, 22);
            this.txtTitre.TabIndex = 5;
            this.txtTitre.TextChanged += new System.EventHandler(this.txtTitre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Durée";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre";
            // 
            // txtDurée
            // 
            this.txtDurée.Location = new System.Drawing.Point(455, 70);
            this.txtDurée.Name = "txtDurée";
            this.txtDurée.Size = new System.Drawing.Size(152, 22);
            this.txtDurée.TabIndex = 9;
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(455, 112);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(232, 24);
            this.cboGenre.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(455, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 22);
            this.textBox3.TabIndex = 12;
            // 
            // btnSupprGenre
            // 
            this.btnSupprGenre.Location = new System.Drawing.Point(713, 112);
            this.btnSupprGenre.Name = "btnSupprGenre";
            this.btnSupprGenre.Size = new System.Drawing.Size(75, 23);
            this.btnSupprGenre.TabIndex = 13;
            this.btnSupprGenre.Text = "Suppr genre";
            this.btnSupprGenre.UseVisualStyleBackColor = true;
            // 
            // btnAjoutGenre
            // 
            this.btnAjoutGenre.Location = new System.Drawing.Point(713, 151);
            this.btnAjoutGenre.Name = "btnAjoutGenre";
            this.btnAjoutGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutGenre.TabIndex = 14;
            this.btnAjoutGenre.Text = "Ajout genre";
            this.btnAjoutGenre.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Acteurs";
            // 
            // lstActeur
            // 
            this.lstActeur.FormattingEnabled = true;
            this.lstActeur.ItemHeight = 16;
            this.lstActeur.Location = new System.Drawing.Point(445, 199);
            this.lstActeur.Name = "lstActeur";
            this.lstActeur.Size = new System.Drawing.Size(242, 180);
            this.lstActeur.TabIndex = 16;
            // 
            // btnAjoutActeurDvd
            // 
            this.btnAjoutActeurDvd.Location = new System.Drawing.Point(693, 218);
            this.btnAjoutActeurDvd.Name = "btnAjoutActeurDvd";
            this.btnAjoutActeurDvd.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutActeurDvd.TabIndex = 17;
            this.btnAjoutActeurDvd.Text = "+";
            this.btnAjoutActeurDvd.UseVisualStyleBackColor = true;
            // 
            // btnSupprActeurDvd
            // 
            this.btnSupprActeurDvd.Location = new System.Drawing.Point(693, 247);
            this.btnSupprActeurDvd.Name = "btnSupprActeurDvd";
            this.btnSupprActeurDvd.Size = new System.Drawing.Size(75, 23);
            this.btnSupprActeurDvd.TabIndex = 18;
            this.btnSupprActeurDvd.Text = "-";
            this.btnSupprActeurDvd.UseVisualStyleBackColor = true;
            // 
            // cboActeur
            // 
            this.cboActeur.FormattingEnabled = true;
            this.cboActeur.Location = new System.Drawing.Point(445, 385);
            this.cboActeur.Name = "cboActeur";
            this.cboActeur.Size = new System.Drawing.Size(242, 24);
            this.cboActeur.TabIndex = 19;
            // 
            // txtAjoutActeur
            // 
            this.txtAjoutActeur.Location = new System.Drawing.Point(445, 416);
            this.txtAjoutActeur.Name = "txtAjoutActeur";
            this.txtAjoutActeur.Size = new System.Drawing.Size(242, 22);
            this.txtAjoutActeur.TabIndex = 20;
            // 
            // btnSupprActeur
            // 
            this.btnSupprActeur.Location = new System.Drawing.Point(719, 385);
            this.btnSupprActeur.Name = "btnSupprActeur";
            this.btnSupprActeur.Size = new System.Drawing.Size(75, 23);
            this.btnSupprActeur.TabIndex = 21;
            this.btnSupprActeur.Text = "Suppr acteur";
            this.btnSupprActeur.UseVisualStyleBackColor = true;
            // 
            // btnAjoutActeur
            // 
            this.btnAjoutActeur.Location = new System.Drawing.Point(719, 415);
            this.btnAjoutActeur.Name = "btnAjoutActeur";
            this.btnAjoutActeur.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutActeur.TabIndex = 22;
            this.btnAjoutActeur.Text = "Ajout acteur";
            this.btnAjoutActeur.UseVisualStyleBackColor = true;
            this.btnAjoutActeur.Click += new System.EventHandler(this.btnAjoutActeur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjoutActeur);
            this.Controls.Add(this.btnSupprActeur);
            this.Controls.Add(this.txtAjoutActeur);
            this.Controls.Add(this.cboActeur);
            this.Controls.Add(this.btnSupprActeurDvd);
            this.Controls.Add(this.btnAjoutActeurDvd);
            this.Controls.Add(this.lstActeur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAjoutGenre);
            this.Controls.Add(this.btnSupprGenre);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.txtDurée);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.btnModifDvd);
            this.Controls.Add(this.btnSupprDvd);
            this.Controls.Add(this.btnAjoutDvd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDvd);
            this.Name = "Form1";
            this.Text = "Gestion des DVD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDvd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjoutDvd;
        private System.Windows.Forms.Button btnSupprDvd;
        private System.Windows.Forms.Button btnModifDvd;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDurée;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSupprGenre;
        private System.Windows.Forms.Button btnAjoutGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstActeur;
        private System.Windows.Forms.Button btnAjoutActeurDvd;
        private System.Windows.Forms.Button btnSupprActeurDvd;
        private System.Windows.Forms.ComboBox cboActeur;
        private System.Windows.Forms.TextBox txtAjoutActeur;
        private System.Windows.Forms.Button btnSupprActeur;
        private System.Windows.Forms.Button btnAjoutActeur;
    }
}


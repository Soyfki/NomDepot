namespace Exo2a
{
    partial class frmEco2a
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_couleur = new System.Windows.Forms.GroupBox();
            this.rbt_rouge = new System.Windows.Forms.RadioButton();
            this.rbt_vert = new System.Windows.Forms.RadioButton();
            this.rbt_bleu = new System.Windows.Forms.RadioButton();
            this.checkBox_couleur = new System.Windows.Forms.CheckBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.groupBox_couleur.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Démonstration des cases à cocher\r\net des boutons d\'options";
            // 
            // groupBox_couleur
            // 
            this.groupBox_couleur.Controls.Add(this.rbt_bleu);
            this.groupBox_couleur.Controls.Add(this.rbt_vert);
            this.groupBox_couleur.Controls.Add(this.rbt_rouge);
            this.groupBox_couleur.Location = new System.Drawing.Point(131, 221);
            this.groupBox_couleur.Name = "groupBox_couleur";
            this.groupBox_couleur.Size = new System.Drawing.Size(169, 122);
            this.groupBox_couleur.TabIndex = 1;
            this.groupBox_couleur.TabStop = false;
            this.groupBox_couleur.Text = "Couleur";
            this.groupBox_couleur.Visible = false;
            // 
            // rbt_rouge
            // 
            this.rbt_rouge.AutoSize = true;
            this.rbt_rouge.Location = new System.Drawing.Point(6, 19);
            this.rbt_rouge.Name = "rbt_rouge";
            this.rbt_rouge.Size = new System.Drawing.Size(57, 17);
            this.rbt_rouge.TabIndex = 0;
            this.rbt_rouge.TabStop = true;
            this.rbt_rouge.Text = "&Rouge";
            this.rbt_rouge.UseVisualStyleBackColor = true;
            this.rbt_rouge.CheckedChanged += new System.EventHandler(this.rbt_rouge_CheckedChanged);
            // 
            // rbt_vert
            // 
            this.rbt_vert.AutoSize = true;
            this.rbt_vert.Location = new System.Drawing.Point(6, 54);
            this.rbt_vert.Name = "rbt_vert";
            this.rbt_vert.Size = new System.Drawing.Size(44, 17);
            this.rbt_vert.TabIndex = 1;
            this.rbt_vert.TabStop = true;
            this.rbt_vert.Text = "&Vert";
            this.rbt_vert.UseVisualStyleBackColor = true;
            this.rbt_vert.CheckedChanged += new System.EventHandler(this.rbt_vert_CheckedChanged);
            // 
            // rbt_bleu
            // 
            this.rbt_bleu.AutoSize = true;
            this.rbt_bleu.Location = new System.Drawing.Point(6, 88);
            this.rbt_bleu.Name = "rbt_bleu";
            this.rbt_bleu.Size = new System.Drawing.Size(46, 17);
            this.rbt_bleu.TabIndex = 2;
            this.rbt_bleu.TabStop = true;
            this.rbt_bleu.Text = "&Bleu";
            this.rbt_bleu.UseVisualStyleBackColor = true;
            this.rbt_bleu.CheckedChanged += new System.EventHandler(this.rbt_bleu_CheckedChanged);
            // 
            // checkBox_couleur
            // 
            this.checkBox_couleur.AutoSize = true;
            this.checkBox_couleur.Location = new System.Drawing.Point(13, 56);
            this.checkBox_couleur.Name = "checkBox_couleur";
            this.checkBox_couleur.Size = new System.Drawing.Size(112, 17);
            this.checkBox_couleur.TabIndex = 2;
            this.checkBox_couleur.Text = "Modifier la couleur";
            this.checkBox_couleur.UseVisualStyleBackColor = true;
            this.checkBox_couleur.CheckedChanged += new System.EventHandler(this.checkBox_couleur_CheckedChanged);
            // 
            // lblCouleur
            // 
            this.lblCouleur.BackColor = System.Drawing.Color.Red;
            this.lblCouleur.Location = new System.Drawing.Point(134, 57);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(166, 152);
            this.lblCouleur.TabIndex = 3;
            this.lblCouleur.Text = "La couleur choisie";
            // 
            // frmEco2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 352);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.checkBox_couleur);
            this.Controls.Add(this.groupBox_couleur);
            this.Controls.Add(this.label1);
            this.Name = "frmEco2a";
            this.Text = "Exercice 2a : couleurs";
            this.groupBox_couleur.ResumeLayout(false);
            this.groupBox_couleur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_couleur;
        private System.Windows.Forms.RadioButton rbt_bleu;
        private System.Windows.Forms.RadioButton rbt_vert;
        private System.Windows.Forms.RadioButton rbt_rouge;
        private System.Windows.Forms.CheckBox checkBox_couleur;
        private System.Windows.Forms.Label lblCouleur;
    }
}


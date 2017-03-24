using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo2a
{
    /* cet exercice permet d'illustrer le fonctionnement
    * d'une case à cocher
    * d'un groupe de boutons radio
    * Pour fonctionner de manière exclusive, les boutons radio
    * doivent être placés dans un objet groupBox
    */

    /// <summary>
    /// ce programme change la couleur d'un label en fonction du bouton radio sélectionné
    /// </summary>

    public partial class frmEco2a : Form
    {
        public frmEco2a()
        {
            InitializeComponent();
            this.Height = 250; // hauteur réduite sans boutons radio
        }

        /// <summary>
        /// lorsque la case est cochée le groupe de boutons de couleur est visible et inversement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_couleur_CheckedChanged(object sender, EventArgs e)
        {
            /* lorsque la case est cochée le groupe de boutons de couleur est visible
            * et inversement ==> corrélation entre les 2 valeurs de propriétés 
            */
            this.groupBox_couleur.Visible = this.checkBox_couleur.Checked;  // il s’agit de 2 valeur booléennes

            // ajuster la hauteur du form
            if (this.checkBox_couleur.Checked)
                this.Height = 390;  // grande hauteur affichant les boutons radio
            else
                this.Height = 250;  // hauteur réduite sans boutons radio

        }

        /// <summary>
        /// si ce bouton est coché, le label devient vert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_vert_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbt_vert.Checked)
                this.lblCouleur.BackColor = System.Drawing.Color.Yellow;
        }

        /// <summary>
        /// si ce bouton est coché, le label devient bleu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_bleu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbt_bleu.Checked)
                this.lblCouleur.BackColor = System.Drawing.Color.Blue;
        }

        /// <summary>
        /// si ce bouton est coché, le label devient rouge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbt_rouge.Checked)
                this.lblCouleur.BackColor = System.Drawing.Color.Red;
        }
    }
}

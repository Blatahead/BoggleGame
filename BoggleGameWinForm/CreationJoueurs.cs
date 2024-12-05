using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BoggleGameWinForm
{
    public partial class CreationJoueurs : Form
    {
        #region Attributs
        private Joueur[] joueursPartie;
        #endregion

        #region Constructeur
        public CreationJoueurs()
        {
            InitializeComponent();
            // Initialisez les joueurs avec des valeurs par défaut ou null
            this.joueursPartie = new Joueur[2];
        }
        #endregion

        #region Propriété
        public Joueur[] JoueursPartie
        {
            get { return this.joueursPartie; }
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Crée un tableau de joueurs en fonction des champs texte.
        /// </summary>
        /// <returns>Un tableau de joueurs.</returns>
        private Joueur[] CreationTabJoueurs()
        {
            Joueur j1 = new Joueur(this.pseudoJoueur1.Text.Trim());
            Joueur j2 = new Joueur(this.pseudoJoueur2.Text.Trim());
            return new Joueur[] { j1, j2 };
        }

        /// <summary>
        /// Gestionnaire d'événement pour le bouton de confirmation de création des joueurs.
        /// </summary>
        private void ConfirmationCreationJoueurs_Click(object sender, EventArgs e)
        {
            // Créez les joueurs
            this.joueursPartie = CreationTabJoueurs();

            // Validez et fermez la fenêtre
            if (joueursPartie != null && joueursPartie.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }
        #endregion
    }
}
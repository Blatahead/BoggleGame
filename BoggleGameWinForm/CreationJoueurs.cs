using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
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
            CustomizeButtons();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Image.FromFile("./../../../../background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

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
        #region Design Bouton
        /// <summary>
        /// Design du bouton de la page de creation des joueurs
        /// </summary>
        private void CustomizeButtons()
        {
            ConfigureButton(this.confirmCreationJoueurs);

            this.Resize += (s, e) =>
            {
                PositionButton(this.confirmCreationJoueurs, 2, -100);
            };
        }

        /// <summary>
        /// Design d'un bouton
        /// </summary>
        /// <param name="button"></param>
        private void ConfigureButton(Button button)
        {
            button.BackColor = Color.FromArgb(128, 45, 156, 219);
            button.ForeColor = Color.White;
            button.Font = new Font("Young Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            button.Paint += Button_Paint;
        }
        /// <summary>
        /// Méthode qui arrondi les coins d'un bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;

            // Coins arrondis
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, 20, 20, 180, 90); 
                path.AddArc(btn.Width - 20, 0, 20, 20, 270, 90); 
                path.AddArc(btn.Width - 20, btn.Height - 20, 20, 20, 0, 90); 
                path.AddArc(0, btn.Height - 20, 20, 20, 90, 90); 
                path.CloseAllFigures();

                btn.Region = new Region(path);
            }
        }
        #endregion

        /// <summary>
        /// Méthode qui gère la position et la taille d'un bouton.
        /// Sert au responsive d'un bouton.
        /// </summary>
        /// <param name="button"></param>
        /// <param name="diviseurDeLargeur"></param>
        /// <param name="decalageVertical"></param>
        private void PositionButton(Button button, int diviseurDeLargeur, int decalageVertical)
        {
            int largeur = this.ClientSize.Width / diviseurDeLargeur; 
            int hauteur = 90; 
            int posX = (this.ClientSize.Width - largeur) / 2; 
            int posY = (this.ClientSize.Height / 2) + decalageVertical; 

            button.Size = new Size(largeur, hauteur);
            button.Location = new Point(posX, posY);
        }

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
            this.joueursPartie = CreationTabJoueurs();

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
using BoggleGameWinForm;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ClassLibrary;

namespace BoggleGame
{
    public partial class Accueil : Form
    {
        #region Constructeurs
        public Accueil()
        {
            InitializeComponent();
            CustomizeButtons();

            // Délai avant de charger l'image
            this.Load += async (s, e) =>
            {
                try
                {
                    await Task.Delay(250);

                    this.BackgroundImage = Image.FromFile("./../../../../background.jpg");
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message);
                }
            };
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Design de tous les boutons de l'accueil
        /// </summary>
        private void CustomizeButtons()
        {
            ConfigureButton(newGameBtn);
            ConfigureButton(buttonRules);

            // Responsive
            this.Resize += (s, e) =>
            {
                PositionButton(newGameBtn, 2, -100);
                PositionButton(buttonRules, 2, 100);
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
            button.Font = new Font("Young Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
                path.AddArc(0, 0, 20, 20, 180, 90); // Haut gauche
                path.AddArc(btn.Width - 20, 0, 20, 20, 270, 90); // Haut droit
                path.AddArc(btn.Width - 20, btn.Height - 20, 20, 20, 0, 90); // Bas droit
                path.AddArc(0, btn.Height - 20, 20, 20, 90, 90); // Bas gauche
                path.CloseAllFigures();

                btn.Region = new Region(path);
            }
        }

        /// <summary>
        /// Méthode qui gère la position et la taille d'un bouton.
        /// Sert au responsive d'un bouton.
        /// </summary>
        /// <param name="button"></param>
        /// <param name="widthDivider"></param>
        /// <param name="verticalOffset"></param>
        private void PositionButton(Button button, int widthDivider, int verticalOffset)
        {
            int largeur = this.ClientSize.Width / widthDivider; // Fraction de largeur disponible
            int hauteur = 90; // Hauteur fixe
            int posX = (this.ClientSize.Width - largeur) / 2; // Centré horizontalement
            int posY = (this.ClientSize.Height / 2) + verticalOffset; // Décalage vertical

            button.Size = new Size(largeur, hauteur);
            button.Location = new Point(posX, posY);
        }

        /// <summary>
        /// Lance la partie si bouton cliqué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGameClick(object sender, EventArgs e)
        {
            Partie partie = new Partie();
            partie.Show();
        }

        /// <summary>
        /// Affiche la page de règles si bouton cliqué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRulesClick(object sender, EventArgs e)
        {
            Regles regles = new Regles();
            regles.Show();
        }
        #endregion
    }
}

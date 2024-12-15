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
        private Image imageFond;

        public Accueil()
        {
            InitializeComponent();
            CustomizeButtons();

            // Afficher un délai avant de charger l'image
            this.Load += async (s, e) =>
            {
                try
                {
                    // Simuler un délai (optionnel)
                    await Task.Delay(250);

                    // Charger l'image
                    imageFond = Image.FromFile("./../../../../background.jpg");

                    // Appliquer l'image comme fond
                    this.BackgroundImage = imageFond;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message);
                }
            };
        }




        private void CustomizeButtons()
        {
            // Configurer le bouton "Nouvelle partie"
            ConfigureButton(newGameBtn);

            // Configurer le bouton "Règles"
            ConfigureButton(buttonRules);

            // Ajuster la taille et la position des boutons dynamiquement
            this.Resize += (s, e) =>
            {
                // Bouton "Nouvelle partie" : centré en haut
                PositionButton(newGameBtn, 2, -100);

                // Bouton "Règles" : centré en bas
                PositionButton(buttonRules, 2, 100);
            };
        }

        private void ConfigureButton(Button button)
        {
            button.BackColor = Color.FromArgb(128, 45, 156, 219); // Bleu doux avec opacité
            button.ForeColor = Color.White; // Texte en blanc
            button.Font = new Font("Young Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            // Coins arrondis
            button.Paint += Button_Paint;
        }

        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;

            // Créer un pinceau pour les coins arrondis
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, 20, 20, 180, 90); // Coin supérieur gauche
                path.AddArc(btn.Width - 20, 0, 20, 20, 270, 90); // Coin supérieur droit
                path.AddArc(btn.Width - 20, btn.Height - 20, 20, 20, 0, 90); // Coin inférieur droit
                path.AddArc(0, btn.Height - 20, 20, 20, 90, 90); // Coin inférieur gauche
                path.CloseAllFigures();

                // Appliquer la région arrondie
                btn.Region = new Region(path);

                // Dessiner un contour
                using (Pen pen = new Pen(Color.FromArgb(35, 135, 200), 2))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void PositionButton(Button button, int widthDivider, int verticalOffset)
        {
            int largeur = this.ClientSize.Width / widthDivider; // Fraction de largeur disponible
            int hauteur = 90; // Hauteur fixe
            int posX = (this.ClientSize.Width - largeur) / 2; // Centré horizontalement
            int posY = (this.ClientSize.Height / 2) + verticalOffset; // Décalage vertical

            button.Size = new Size(largeur, hauteur);
            button.Location = new Point(posX, posY);
        }

        private void Chargement_Accueil(object sender, EventArgs e)
        {
            int hauteur = Screen.PrimaryScreen.Bounds.Height;
            int largeur = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0, 0);
            this.Size = new Size(largeur, hauteur);
        }

        private void ButtonGameClick(object sender, EventArgs e)
        {
            Partie partie = new Partie();
            partie.Show();
        }

        private void buttonRulesClick(object sender, EventArgs e)
        {
            Regles regles = new Regles();
            regles.Show();
        }
    }
}

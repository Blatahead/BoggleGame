using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BoggleGameWinForm
{
    public partial class Configurations : Form
    {
        #region Attributs
        string langue;
        int taillePlateau;
        bool isTrie;
        #endregion

        #region Proprietes

        public string Langue
        {
            get { return this.langue; }
            set { this.langue = value; }
        }

        public int TaillePlateau
        {
            get { return this.taillePlateau; }
        }

        public bool IsTrie
        {
            get { return this.isTrie; }
        }
        #endregion
        #region Constructeur

        public Configurations()
        {
            InitializeComponent();
            CustomizeButtons();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Image.FromFile("./../../../../background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.comboBoxLangue.SelectedItem = "Français";//Remplissage par défaut
            this.comboBoxTaille.SelectedItem = "4x4";//Remplissage par défaut

            this.langue = "Français";//Par défaut
            this.taillePlateau = 4;//Par défaut
            this.isTrie = true;//Par défaut
        }

        #endregion

        #region Méthodes
        private void CustomizeButtons()
        {
            // Configurer le bouton "Nouvelle partie"
            ConfigureButton(this.saveConfigButton);

            // Ajuster la taille et la position des boutons dynamiquement
            this.Resize += (s, e) =>
            {
                // Bouton "Nouvelle partie" : centré en haut
                PositionButton(this.saveConfigButton, 2, -100);
            };
        }

        private void ConfigureButton(Button button)
        {
            button.BackColor = Color.FromArgb(128, 45, 156, 219); // Bleu doux avec opacité
            button.ForeColor = Color.White; // Texte en blanc
            button.Font = new Font("Young Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
        #region FetchDonnéesDeLaPage
        private string FetchLangue()
        {
            this.langue = this.comboBoxLangue.SelectedItem.ToString();
            return this.langue;
        }
        private int FetchTaille()
        {
            string taillePlateau = this.comboBoxTaille.SelectedItem.ToString();

            switch (taillePlateau)
            {
                case "4x4":
                    this.taillePlateau = 4;
                    return 4;
                case "5x5":
                    this.taillePlateau = 5;
                    return 5;
                case "6x6":
                    this.taillePlateau = 6;
                    return 6;
                case "7x7":
                    this.taillePlateau = 7;
                    return 7;
                case "8x8":
                    this.taillePlateau = 8;
                    return 8;
                case "9x9":
                    this.taillePlateau = 9;
                    return 9;
                case "10x10":
                    this.taillePlateau = 10;
                    return 10;
                default:
                    throw new ArgumentException("Taille de plateau invalide.");
            }
        }

        private bool FetchIsTrie()
        {
            this.isTrie = this.isTrieText.Text == "Non trié" ? false : true;
            return this.isTrie;
        }

        #endregion
        private void label5_Click(object sender, EventArgs e)
        {
            //appel d'une fonction de tri
        }
        private void saveConfigButton_Click(object sender, EventArgs e)
        {;
            FetchLangue();
            FetchTaille();
            FetchIsTrie();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}

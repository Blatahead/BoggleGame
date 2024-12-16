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

namespace BoggleGameWinForm
{
    public partial class Configurations : Form
    {
        #region Attributs
        string langue;
        int taillePlateau;
        #endregion

        #region Proprietes

        public string Langue
        { get { return this.langue; } set { this.langue = value; } }

        public int TaillePlateau
        { get { return this.taillePlateau; }}

        #endregion

        #region Constructeur
        public Configurations()
        {
            InitializeComponent();
            CustomizeButtons();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Image.FromFile("./../../../../background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.comboBoxLangue.SelectedItem = "Français";
            this.comboBoxTaille.SelectedItem = "4x4";

            this.langue = "Français";
            this.taillePlateau = 4;
        }
        #endregion

        #region Méthodes

        #region Design Bouton
        /// <summary>
        /// Design du bouton de la page de configuration
        /// </summary>
        private void CustomizeButtons()
        {
            ConfigureButton(this.saveConfigButton);

            this.Resize += (s, e) =>
            {
                PositionButton(this.saveConfigButton, 2, -100);
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
        #region FetchDonnéesDeLaPage
        /// <summary>
        /// Récupère la langue entrée dans la boti de dialogue associée
        /// </summary>
        /// <returns></returns>
        private string FetchLangue()
        {
            this.langue = this.comboBoxLangue.SelectedItem.ToString();
            return this.langue;
        }
        /// <summary>
        /// Récupère la taille de plateau sélectionnée dans la liste
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
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

        #endregion
        /// <summary>
        /// Enregistre les données saisies.
        /// Ferme la page de configuration.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveConfigButton_Click(object sender, EventArgs e)
        {;
            FetchLangue();
            FetchTaille();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}
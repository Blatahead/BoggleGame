using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.comboBoxLangue.SelectedItem = "Français";//Remplissage par défaut
            this.comboBoxTaille.SelectedItem = "4x4";//Remplissage par défaut

            this.langue = "Français";//Par défaut
            this.taillePlateau = 4;//Par défaut
            this.isTrie = true;//Par défaut
        }

        #endregion

        #region Méthodes

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

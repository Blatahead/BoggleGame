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
        string taillePlateau;
        bool isTrie;
        #endregion

        #region Proprietes

        public string Langue
        {
            get { return this.langue; }
            set { this.langue = value; }
        }

        public string TaillePlateau
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
            this.comboBoxLangue.SelectedItem = "Français";//Remplissage par défaut
            this.comboBoxTaille.SelectedItem = "4x4";//Remplissage par défaut

            this.langue = "Français";//Par défaut
            this.taillePlateau = "4x4";//Par défaut
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
        private string FetchTaille()
        {
            this.taillePlateau = this.comboBoxTaille.SelectedItem.ToString();
            return this.taillePlateau;
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

            this.Close();
        }

        #endregion


    }
}

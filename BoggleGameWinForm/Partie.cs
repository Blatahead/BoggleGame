using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using ClassLibrary;
using Microsoft.VisualBasic;


namespace BoggleGameWinForm
{
    public partial class Partie : Form
    {
        #region Attributs

        string langue;
        int taillePlateau;
        Joueur[] joueurs;
        Joueur currentJoueur;
        private System.Windows.Forms.Timer clockPartie;
        private System.Windows.Forms.Timer clockJoueur;

        private TimeSpan tempsRestant;
        private Plateau plateau;

        #endregion

        #region Constructeur

        public Partie()
        {
            InitializeComponent();
            // Première page : création des joueurs
            CreationJoueurs creationJoueurs = new CreationJoueurs();
            if (creationJoueurs.ShowDialog() == DialogResult.OK)
            {
                this.joueurs = creationJoueurs.JoueursPartie;

                // Deuxième page imbriquée : configuration des paramètres
                Configurations config = new Configurations();
                if (config.ShowDialog() == DialogResult.OK)
                {
                    this.langue = config.Langue;
                    this.taillePlateau = config.TaillePlateau;
                    this.plateau = new Plateau(this.taillePlateau, "./../../../../Lettres.txt");

                    // Test des paramètres choisis
                    MessageBox.Show($"Taille du plateau : {this.taillePlateau}");

                    //////////////////////////////////////////////////////////////////////
                    /// Voir pour faire l'affichage directement dans la classe Plateau ///
                    //////////////////////////////////////////////////////////////////////
                    ConfigurerTableLayoutPanel(this.taillePlateau);
                    RemplirTableLayoutPanel(plateau);

                    DemarrerTimerPartie();

                    //Démarrer les tours
                    NouveauTourJoueur();
                    MessageBox.Show(plateau.toString());
                }
                else
                {
                    MessageBox.Show("Configuration annulée.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Création des joueurs annulée.");
                this.Close();
            }
        }

        #endregion

        #region Methodes

        ////////////////////////////////////////////////////////
        /// voir pour le mettre dans Partir.Designer.cs ???? ///
        ////////////////////////////////////////////////////////
        private void ConfigurerTableLayoutPanel(int taille)
        {
            PlateauPartie.Controls.Clear();
            PlateauPartie.RowCount = taille;
            PlateauPartie.ColumnCount = taille;

            PlateauPartie.RowStyles.Clear();
            PlateauPartie.ColumnStyles.Clear();
            for (int i = 0; i < taille; i++)
            {
                PlateauPartie.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / taille));
                PlateauPartie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / taille));
            }
        }

        private void RemplirTableLayoutPanel(Plateau plateau)
        {
            Random rand = new Random();
            for (int i = 0; i < this.taillePlateau; i++)
            {
                for (int j = 0; j < this.taillePlateau; j++)
                {
                    // Placer les faces visibles dans la grille du plateau
                    char face = plateau.Matrice[i, j].FaceVisible;
                    Label label = new Label
                    {
                        Text = face.ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font("Arial", 16, FontStyle.Bold)
                    };

                    PlateauPartie.Controls.Add(label, j, i);
                }
            }
        }

        private void DemarrerTimerPartie()
        {
            this.tempsRestant = TimeSpan.FromMinutes(6);

            this.clockPartie = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            this.clockPartie.Tick += (s, e) =>
            {
                //soustraire d'une seconde
                this.tempsRestant = this.tempsRestant.Subtract(TimeSpan.FromSeconds(1));
                //remplacer la valeur du chrono à chaque seconde
                this.chronoPartie.Text = tempsRestant.ToString();
                if (tempsRestant <= TimeSpan.Zero)
                {
                    clockPartie.Stop();
                    MessageBox.Show("Temps écoulé !");
                }
            };

            this.clockPartie.Start();
        }


        


        private void NouveauTourJoueur()
        {
            //next joueur
            this.currentJoueur = this.joueurs[0];
            this.peudoJoueur.Text = this.currentJoueur.Pseudo;
            DemarrerTimerJoueur();
        }
        private void DemarrerTimerJoueur()

        {
            TimeSpan tempsRestantJoueur = this.currentJoueur.TempsRestant;
            tempsRestantJoueur = TimeSpan.FromMinutes(1);

            this.clockJoueur = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            this.clockJoueur.Tick += (s, e) =>
            {
                //soustraire d'une seconde
                tempsRestantJoueur = tempsRestantJoueur.Subtract(TimeSpan.FromSeconds(1));
                //remplacer la valeur du chrono à chaque seconde
                this.chronoJoueur.Text = tempsRestantJoueur.ToString();
                if (tempsRestantJoueur <= TimeSpan.Zero)
                {
                    clockJoueur.Stop();
                    MessageBox.Show("Temps écoulé !");
                }
            };
            this.clockJoueur.Start();
        }

        

        private void Partie_Load(object sender, EventArgs e)
        {
            inputBoxMots.Left = (this.ClientSize.Width - inputBoxMots.Width) / 2;
            inputBoxMots.Top = (this.ClientSize.Height - inputBoxMots.Height) / 2;
            inputBoxMots.Anchor = AnchorStyles.None;
        }

        #endregion

    }
}

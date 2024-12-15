using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace BoggleGameWinForm
{
    public partial class Partie : Form
    {
        #region Attributs

        string langue;
        int taillePlateau;
        Joueur[] joueurs;
        Joueur currentJoueur;
        Plateau plateau;
        Dictionnaire dictionnaire;

        private System.Windows.Forms.Timer horlogePartie;
        private System.Windows.Forms.Timer horlogeJoueur;

        private TimeSpan tempsRestant;

        bool isRunning;

        #endregion

        #region Constructeur

        public Partie()
        {
            InitializeComponent();

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
                    this.dictionnaire = new Dictionnaire(this.langue);
                    this.dictionnaire.Recuperation_Dico();

                    this.taillePlateau = config.TaillePlateau;
                    this.plateau = new Plateau(this.taillePlateau, "./../../../../Lettres.txt");

                    ConfigurerTableLayoutPanel(this.taillePlateau);

                    //Troisième page imbriquée : la partie s'affiche quand la config part
                    RemplirTableLayoutPanel(plateau);

                    DemarrerTimerPartie();

                    NouveauTourJoueur();
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

        #region Méthodes
        /// <summary>
        /// Cette méthode permet de donner tant de lignes et de colonnes à la grille du plateau
        /// </summary>
        /// <param name="taille"></param>
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

        /// <summary>
        /// Permet de remplir la grille du plateau avec les faces visibles des dés contenus dans la matrice du plateau
        /// </summary>
        /// <param name="plateau"></param>
        private void RemplirTableLayoutPanel(Plateau plateau)
        {
            for (int i = 0; i < this.taillePlateau; i++)
            {
                for (int j = 0; j < this.taillePlateau; j++)
                {
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

        /// <summary>
        /// Démarre le timer général de la partie et vérifie s'il est arrivé à zéro
        /// </summary>
        private void DemarrerTimerPartie()
        {
            this.tempsRestant = TimeSpan.FromMinutes(2);

            this.horlogePartie = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            this.horlogePartie.Tick += (s, e) =>
            {
                this.tempsRestant = this.tempsRestant.Subtract(TimeSpan.FromSeconds(1));
                this.chronoPartie.Text = tempsRestant.ToString();

                if (tempsRestant <= TimeSpan.Zero)
                {
                    horlogePartie.Stop();

                    // fin de partie
                    MessageBox.Show("Temps écoulé !");

                    foreach (Joueur joueur in this.joueurs)
                    {
                        joueur.Score += joueur.ComptagePointsParLongueur();
                    }

                    MessageBox.Show($"{this.joueurs[0].Pseudo} a {this.joueurs[0].Score} points.\n" +
                                    $"{this.joueurs[1].Pseudo} a {this.joueurs[1].Score} points.");
                }
            };
            this.horlogePartie.Start();
        }

        /// <summary>
        /// Méthode qui stop un objet de type Timer et le modifie en même temps partout où il est appelé
        /// </summary>
        /// <param name="timer"></param>
        /// <param name="estEnCours"></param>
        private void PauseTimer(System.Windows.Forms.Timer timer, ref bool estEnCours)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                estEnCours = true;
            }
            else
            {
                estEnCours = false;
            }
        }

        /// <summary>
        /// Méthode qui redémarre un objet de type Timer et le modifie en même temps partout où il est appelé
        /// </summary>
        /// <param name="timer"></param>
        /// <param name="wasRunning"></param>
        private void ReprendreTimer(System.Windows.Forms.Timer timer, bool wasRunning)
        {
            if (wasRunning)
            {
                timer.Start();
            }
        }

        /// <summary>
        /// Permet de lancer le premier tour de la partie
        /// </summary>
        private void NouveauTourJoueur()
        {
            this.isRunning = true;
            this.currentJoueur = this.joueurs[0];
            this.peudoJoueur.Text = this.currentJoueur.Pseudo;
            TimerJoueur();
        }

        /// <summary>
        /// Démarre le timer d'un joueur et vérifie s'il est arrivé à zéro
        /// </summary>
        private void TimerJoueur()
        {
            TimeSpan tempsRestantJoueur = TimeSpan.FromMinutes(1);

            this.horlogeJoueur = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            this.horlogeJoueur.Tick += (s, e) =>
            {
                tempsRestantJoueur = tempsRestantJoueur.Subtract(TimeSpan.FromSeconds(1));
                this.chronoJoueur.Text = tempsRestantJoueur.ToString();

                if (tempsRestantJoueur <= TimeSpan.Zero)
                {
                    horlogeJoueur.Stop();

                    bool partieEnCours = false;
                    PauseTimer(this.horlogePartie, ref partieEnCours);

                    MessageBox.Show($"Tour terminé ! Voici les mots trouvés par {currentJoueur.Pseudo} :\n" +
                                    $"{currentJoueur.toStringListeMotsTrouves()}" +
                                    $"\nScore final : {currentJoueur.Score}");

                    ReprendreTimer(this.horlogePartie, partieEnCours);

                    PasserAuProchainJoueur();
                }
            };

            this.horlogeJoueur.Start();
        }

        /// <summary>
        /// Permet de passer au joueur suivant
        /// </summary>
        private void PasserAuProchainJoueur()
        {
            int indexCurrent = Array.IndexOf(joueurs, currentJoueur);
            int nextIndex = (indexCurrent + 1) % joueurs.Length;
            this.currentJoueur = joueurs[nextIndex];

            // Démarrer le tour du prochain joueur
            this.peudoJoueur.Text = this.currentJoueur.Pseudo;
            TimerJoueur();
        }

        /// <summary>
        /// Extériorise le tri de la liste passée en paramètre
        /// </summary>
        /// <param name="liste"></param>
        /// <returns></returns>
        private List<string> PreparerListePourRecherche(List<string> liste)
        {
            if (liste == null || liste.Count() <= 1)
                return liste;

            Tris.TriFusion(liste, 0, liste.Count() - 1);
            return liste;
        }

        /// <summary>
        /// Se déclenche lors d'un évènemement sur une touche. 
        /// Permet de vérifier et enregistrer la saisie d'un joueur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputBoxMots_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string saisie = this.inputBoxMots.Text.Trim().ToUpper();
                this.inputBoxMots.Clear();

                // Conditions de validité
                bool estValide = saisie.Length >= 2
                    && !saisie.Contains(" ")
                    && this.plateau.TestPlateau(saisie)
                    && this.dictionnaire.SortedList.ContainsKey(saisie[0]) 
                    && this.dictionnaire.SortedList[saisie[0]].ContainsKey(saisie.Length)
                    && this.dictionnaire.SortedList[saisie[0]][saisie.Length].Count > 0
                    && Dictionnaire.RechDichoRecursif(
                        PreparerListePourRecherche(this.dictionnaire.SortedList[saisie[0]][saisie.Length]),
                        saisie,
                        0,
                        this.dictionnaire.SortedList[saisie[0]][saisie.Length].Count - 1);

                // Calculs
                Dictionary<char, int> valeursLettres = Plateau.ChargerDicoValeursLettres("./../../../../Lettres.txt");
                
                char premiereLettre = estValide ? char.ToUpper(saisie[0]) : '\0';
                int longueur = estValide ? saisie.Length : 0;
                string? valeur = estValide ? saisie : saisie;
                int points = this.currentJoueur.ComptagePointsParPoids(estValide, saisie, valeursLettres);

                if (estValide)
                {
                    Mot motTrouve = new Mot(estValide, saisie, points, premiereLettre, longueur);

                    if (!this.currentJoueur.ListeMotsTrouves.Any(m => m.Egale(motTrouve)))
                    {
                        this.currentJoueur.AddMot(motTrouve);
                        this.currentJoueur.Score += points;
                    }
                }
            }
        }
        #endregion
    }
}

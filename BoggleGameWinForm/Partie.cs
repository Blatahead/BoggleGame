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
using ClassLibrary.ClassLibrary;

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
        int nbTours;
        private Dictionary<Joueur, List<Mot>> motsTrouvesTourActuel;

        #endregion

        #region Constructeur
        public Partie()
        {
            InitializeComponent();

            this.nbTours = 0;

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

            CreationJoueurs creationJoueurs = new CreationJoueurs();
            if (creationJoueurs.ShowDialog() == DialogResult.OK)
            {
                this.joueurs = creationJoueurs.JoueursPartie;
                this.motsTrouvesTourActuel = new Dictionary<Joueur, List<Mot>>();
                foreach (Joueur joueur in this.joueurs)
                {
                    this.motsTrouvesTourActuel[joueur] = new List<Mot>();
                }

                Configurations config = new Configurations();
                if (config.ShowDialog() == DialogResult.OK)
                {
                    this.langue = config.Langue;
                    this.dictionnaire = new Dictionnaire(this.langue);
                    this.dictionnaire.Recuperation_Dico();

                    this.taillePlateau = config.TaillePlateau;
                    this.plateau = new Plateau(this.taillePlateau, "./../../../../Lettres.txt");

                    ConfigurerTableLayoutPanel(this.taillePlateau);

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
            this.tempsRestant = TimeSpan.FromMinutes(1.5);

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

                    foreach (Joueur joueur in this.joueurs)
                    {
                        joueur.Score += joueur.ComptagePointsParLongueur();
                        Nuage nuage = new Nuage(Mot.ListeDeMotsEnListeDeString(joueur.ListeMotsTrouves));
                        string cheminFichier = $"nuage_de_mots{joueur.Pseudo}.png";
                        nuage.GenererImageNuage(cheminFichier, 400, 300);
                    }

                    Gagnant(this.joueurs[0], this.joueurs[1]);
                    
                    string cheminFichierNuageBest = "nuage_de_mots_tous.png";
                    Nuage.GenererNuageDepuisPlateau(cheminFichierNuageBest, this.plateau, this.dictionnaire);

                    this.Close();
                    Application.Exit();
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
            this.currentJoueur = this.joueurs[0];
            this.peudoJoueur.Text = this.currentJoueur.Pseudo;
            TimerJoueur();
        }

        /// <summary>
        /// Démarre le timer d'un joueur et vérifie s'il est arrivé à zéro
        /// </summary>
        private void TimerJoueur()
        {
            TimeSpan tempsRestantJoueur = TimeSpan.FromMinutes(0.25);

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
                                    $"\nScore intermédiaire (poids) : {currentJoueur.Score}");

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
            int indiceActuel = Array.IndexOf(joueurs, currentJoueur);
            int indiceDapres = (indiceActuel + 1) % joueurs.Length;
            this.currentJoueur = joueurs[indiceDapres];

            nbTours++;

            if (nbTours % 2 == 0)
            {
                PlateauPartie.Controls.Clear();

                this.plateau = new Plateau(this.taillePlateau, "./../../../../Lettres.txt");

                foreach (Joueur joueur in this.joueurs)
                {
                    motsTrouvesTourActuel[joueur].Clear();
                }

                RemplirTableLayoutPanel(this.plateau);
            }
            this.peudoJoueur.Text = this.currentJoueur.Pseudo;
            TimerJoueur();
        }

        /// <summary>
        /// Détermine le gagnant d'une partie
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        private static void Gagnant(Joueur p1, Joueur p2)
        {
            if (p1.Score > p2.Score)
            {
                MessageBox.Show(p1.Pseudo + " a gagné la partie! Bien joué à tous!\n"
                    + "Temps écoulé !\n"
                        + $"{p1.Pseudo} a {p1.Score} points.\n"
                        + $"{p2.Pseudo} a {p2.Score} points.");
            }
            if (p2.Score > p1.Score)
            {
                MessageBox.Show(p2.Pseudo + " a gagné la partie! Bien joué à tous!\n"
                    + "Temps écoulé !\n"
                        + $"{p1.Pseudo} a {p1.Score} points.\n"
                        + $"{p2.Pseudo} a {p2.Score} points.");
            }
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

                bool estValide = saisie.Length >= 2
                    && !saisie.Contains(" ")
                    && this.plateau.TestPlateau(saisie)
                    && this.dictionnaire.SortedList.ContainsKey(saisie[0])
                    && this.dictionnaire.SortedList[saisie[0]].ContainsKey(saisie.Length)
                    && this.dictionnaire.SortedList[saisie[0]][saisie.Length].Count > 0
                    && Dictionnaire.RechDichoRecursif(
                        Tris.PreparerListePourRecherche(this.dictionnaire.SortedList[saisie[0]][saisie.Length]),
                        saisie,
                        0,
                        this.dictionnaire.SortedList[saisie[0]][saisie.Length].Count - 1);

                Dictionary<char, int> valeursLettres = Dictionnaire.ChargerDicoValeursLettres("./../../../../Lettres.txt");

                char premiereLettre = estValide ? char.ToUpper(saisie[0]) : '\0';
                int longueur = estValide ? saisie.Length : 0;
                string? valeur = estValide ? saisie : saisie;
                int points = this.currentJoueur.ComptagePointsParPoids(estValide, saisie, valeursLettres);

                if (estValide)
                {
                    Mot motTrouve = new Mot(estValide, saisie, points, premiereLettre, longueur);

                    if (!motsTrouvesTourActuel[this.currentJoueur].Any(m => m.Egale(motTrouve)))
                    {
                        motsTrouvesTourActuel[this.currentJoueur].Add(motTrouve);
                        this.currentJoueur.AddMot(motTrouve);
                        this.currentJoueur.Score += points;
                    }
                }
            }
        }

        #endregion
    }
}
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
        Dictionnaire dictionnaire; //sortedlist ?


        private System.Windows.Forms.Timer clockPartie;
        private System.Windows.Forms.Timer clockJoueur;

        private TimeSpan tempsRestant;

        private Image backgroundImage;

        bool isRunning;

        #endregion

        #region Constructeur

        public Partie()
        {
            InitializeComponent();
            // Afficher un délai avant de charger l'image
            this.Load += async (s, e) =>
            {
                try
                {
                    // Simuler un délai (optionnel)
                    await Task.Delay(250);

                    // Charger l'image
                    backgroundImage = Image.FromFile("./../../../../background.jpg");

                    // Appliquer l'image comme fond
                    this.BackgroundImage = backgroundImage;
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
                    this.taillePlateau = config.TaillePlateau;
                    this.plateau = new Plateau(this.taillePlateau, "./../../../../Lettres.txt");

                    // Test des paramètres choisis
                    MessageBox.Show($"Taille du plateau : {this.taillePlateau}");

                    ConfigurerTableLayoutPanel(this.taillePlateau);
                    RemplirTableLayoutPanel(plateau);

                    //creation du dictionnaire de la partie
                    //ptet mettre un timer d'attente
                    this.dictionnaire = new Dictionnaire(this.langue);
                    this.dictionnaire.Recuperation_Dico();


                    DemarrerTimerPartie();

                    // Démarrer les tours
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

        #region Méthodes

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

        private void DemarrerTimerPartie()
        {
            this.tempsRestant = TimeSpan.FromMinutes(2);

            this.clockPartie = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            this.clockPartie.Tick += (s, e) =>
            {
                this.tempsRestant = this.tempsRestant.Subtract(TimeSpan.FromSeconds(1));
                this.chronoPartie.Text = tempsRestant.ToString();
                if (tempsRestant <= TimeSpan.Zero)
                {
                    clockPartie.Stop();
                    MessageBox.Show("Temps écoulé !");
                    foreach(Joueur joueur in this.joueurs)
                    {
                        joueur.Score += joueur.ComptagePointsParLongueur();
                    }
                    MessageBox.Show($"{this.joueurs[0].Pseudo} a {this.joueurs[0].Score} points.\n" +
                        $"{this.joueurs[1].Pseudo} a {this.joueurs[1].Score} points.");
                }
            };

            this.clockPartie.Start();

            //fin de partie faire le comptage avec les longueur
        }
        
        private void NouveauTourJoueur()
        {
            this.isRunning = true;
            this.currentJoueur = this.joueurs[0];
            this.peudoJoueur.Text = this.currentJoueur.Pseudo;
            TimerJoueur();
        }

        private void TimerJoueur()
        {
            TimeSpan tempsRestantJoueur = TimeSpan.FromMinutes(1);

            this.clockJoueur = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            this.clockJoueur.Tick += (s, e) =>
            {
                tempsRestantJoueur = tempsRestantJoueur.Subtract(TimeSpan.FromSeconds(1));
                this.chronoJoueur.Text = tempsRestantJoueur.ToString();
                if (tempsRestantJoueur <= TimeSpan.Zero)
                {
                    clockJoueur.Stop();

                    // MessageBox pour afficher les mots trouvés
                    MessageBox.Show($"Tour terminé ! Voici les mots trouvés par {currentJoueur.Pseudo} :\n" +
                        $"{currentJoueur.toStringListeMotsTrouves()}"+"\n Score final: "+currentJoueur.Score);

                    //MessageBox.Show(this.currentJoueur.toString());

                    // Passer au prochain joueur (ou arrêter la partie)
                    PasserAuProchainJoueur();
                }
            };

            this.clockJoueur.Start();
        }

        private void PasserAuProchainJoueur()
        {
            int indexCurrent = Array.IndexOf(joueurs, currentJoueur);
            int nextIndex = (indexCurrent + 1) % joueurs.Length;
            this.currentJoueur = joueurs[nextIndex];

            // Démarrer le tour du prochain joueur
            this.peudoJoueur.Text = this.currentJoueur.Pseudo;
            TimerJoueur();
        }

        private void inputBoxMots_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string saisie = this.inputBoxMots.Text.Trim();
                this.inputBoxMots.Clear();


                // Conditions de validité
                bool estValide = saisie.Length >= 2 &&
                                 !saisie.Contains(" ");
                                 //&& ;
                                 //&& Dictionnaire.RechDichoRecursif(,saisie,0,);

                // Calculs
                Dictionary<char, int> valeursLettres = Plateau.ChargerDicoValeursLettres("./../../../../Lettres.txt");
                
                int longueur = estValide ? saisie.Length : 0;
                string? valeur = estValide ? saisie : null;
                char premiereLettre = estValide ? saisie[0] : '\0';
                int points = this.currentJoueur.ComptagePointsParPoids(estValide, saisie, valeursLettres);

                // Créer et l'ajouter
                Mot motTrouve = new Mot(estValide, valeur, points, premiereLettre, longueur);
                this.currentJoueur.AddMot(motTrouve);
                this.currentJoueur.Score+=points;

                
                // Message de confirmation
                //if (estValide)
                //{
                //    MessageBox.Show($"Mot ajouté : {motTrouve.Valeur} (Points : {motTrouve.Points})");
                //}
                //else
                //{
                //    MessageBox.Show($"Mot invalide : {saisie}");
                //}
            }
        }

        #endregion

    }
}

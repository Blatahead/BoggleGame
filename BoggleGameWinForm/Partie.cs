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

namespace BoggleGameWinForm
{
    public partial class Partie : Form
    {
        #region Attributs
        string langue;
        string taillePlateau;
        Joueur[] joueurs;
        Joueur currentJoueur;
        TimeSpan dureePartie;
        TimeSpan tempsEcoule;

        #endregion

        #region Constructeur
        public Partie()
        {
            InitializeComponent();

            CreationJoueurs creationJoueurs = new CreationJoueurs();
            if (creationJoueurs.ShowDialog() == DialogResult.OK) // Tant que la création est en cours
            {
                this.joueurs = creationJoueurs.JoueursPartie;
                this.currentJoueur = this.joueurs[0];

                Configurations config = new Configurations();
                config.ShowDialog();
                
                this.langue = config.Langue;
                this.taillePlateau = config.TaillePlateau;

                MessageBox.Show($"Valeurs enregistrées : \n{this.langue}\n{this.taillePlateau}");
                
                this.dureePartie = TimeSpan.FromMinutes(6);
                this.tempsEcoule = TimeSpan.Zero;
            }
            else
            {
                this.Close();
            }
        }
        #endregion

        #region Methodes
        ////////////////////////////////////////////////////////////////
        ////////       FAIRE UNE CLASSE POUR LES TIMER         /////////
        ////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// Fonction qui lance un chrono de partie global
        /// </summary
        static void TimerPartie()
        {
            DateTime timer = DateTime.Now;
            TimeSpan durée = TimeSpan.FromMinutes(6);
            while (true)
            {
                TimeSpan elapsed = DateTime.Now - timer;
                Console.Clear();
                Console.WriteLine("Temps écoulée: " + elapsed.Seconds + "secondes");

                if (elapsed < durée)
                {
                    Console.WriteLine("Votre tour est terminé!");
                    break;
                }
            }
        }
        #endregion
    }
}

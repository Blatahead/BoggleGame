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
        Joueur[] joueurs;
        string currentJoueur;
        #endregion
        #region Constructeur
        public Partie()
        {
            InitializeComponent();

        }
        #endregion

        #region Methodes
        static void Temps_de_partie()
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

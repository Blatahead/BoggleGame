using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BoggleGame
{
    public class Joueur
    {
        string pseudo;
        int compteur_bon_mot;
        int compteur_mauvais_mot;
        #region Constructeurs
        public Joueur(string pseudo)
        {
            this.pseudo = pseudo;
        }
        #endregion
        #region Propriétés
        public string Pseudo
        { get { return this.pseudo; } }
        #endregion


        /// <summary>
        /// Fonction qui lance un chrono pour chaque joueur durant son tour
        /// </summary>
        public void timer()
        {
            DateTime timer = DateTime.Now;
            TimeSpan durée = TimeSpan.FromMinutes(1);
            while (true)
            {
                TimeSpan elapsed = DateTime.Now - timer;
                Console.Clear();
                Console.WriteLine("Temps écoulée: "+elapsed.Seconds+"secondes");

                if (elapsed<durée)
                {
                    Console.WriteLine("Votre tour est terminé!");
                    break;
                }
            }

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassLibrary
{
    public class Joueur
    {
        string pseudo;
        List<string> listeMotsTrouves;
        int compteurBonsMots;
        int compteurMauvaisMots;
        #region Constructeurs
        public Joueur(string pseudo1)
        {
            this.pseudo = pseudo1;
        }

        public Joueur(string pseudo1, List<string> listeMotTrouves1, int compteurBonsMots1, int compteurMauvaisMots1)
        {
            this.pseudo = pseudo1;
            this.listeMotsTrouves = listeMotTrouves1;
            this.compteurBonsMots = compteurBonsMots1;
            this.compteurMauvaisMots = compteurMauvaisMots1;
        }
        #endregion
        #region Propriétés

        public string Pseudo
        { get { return this.pseudo; } }

        #endregion

        #region Méthodes

        /// <summary>
        /// Fonction qui lance un chrono pour chaque joueur durant son tour
        /// </summary>
        public void TimerJoueur()
        {
            DateTime timer = DateTime.Now;
            TimeSpan durée = TimeSpan.FromMinutes(1);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    public class Joueur
    {
        #region Attributs

        string pseudo;
        List<string> listeMotsTrouves;
        TimeSpan tempsRestant;
        int compteurBonsMots;
        int compteurMauvaisMots;

        #endregion

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

        public TimeSpan TempsRestant
        { get { return this.tempsRestant; } set { this.tempsRestant = value; } }

        #endregion

        #region Méthodes
        public int Comptage_Points()
        {
            int total = 0;
            foreach(string word in listeMotsTrouves)
            {
                if (word.Length<5)
                {
                    total+=1;
                }
                if (word.Length==5)
                {
                    total+=2;
                }
                if (word.Length==6)
                {
                    total+=3;
                }
                if (word.Length==7)
                {
                    total+=5;
                }
                if (word.Length>=8)
                {
                    total+=11;
                }

            }
            return total;
        }

        static void Gagnant(Joueur p1,Joueur p2)
        {
            if (p1.Comptage_Points()>p2.Comptage_Points())
            {
                Console.WriteLine(p1.pseudo+" a gagné(e) la partie! Bien joué à tous!");
            }
            if (p2.Comptage_Points()>p1.Comptage_Points())
            {
                Console.WriteLine(p2.pseudo+" a gagné(e) la partie! Bien joué à tous!");
            }

        }

        

        #endregion
    }

}

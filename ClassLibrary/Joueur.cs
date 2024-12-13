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
        List<Mot> listeMotsTrouves;
        TimeSpan tempsRestant;
        int compteurBonsMots;
        int compteurMauvaisMots;

        #endregion

        #region Constructeurs

        public Joueur(string pseudo1)
        {
            this.pseudo = pseudo1;
            this.listeMotsTrouves = new List<Mot>(); //sécurité car nulle au début
        }

        public Joueur(string pseudo1, List<Mot> listeMotTrouves1, int compteurBonsMots1, int compteurMauvaisMots1)
        {
            this.pseudo = pseudo1;
            this.listeMotsTrouves = listeMotTrouves1 ?? new List<Mot>(); //sécurité car nulle au début
            this.compteurBonsMots = compteurBonsMots1;
            this.compteurMauvaisMots = compteurMauvaisMots1;
        }
        #endregion

        #region Propriétés

        public string Pseudo
        { get { return this.pseudo; } }

        public TimeSpan TempsRestant
        { get { return this.tempsRestant; } set { this.tempsRestant = value; } }

        public List<Mot> ListeMotsTrouves
        { get { return this.listeMotsTrouves; } }

        #endregion

        #region Méthodes
        ////////////////////////////////
        ///Timer joueurs à bouger ici///
        /////////////////////////////////
        

        //utiliser où ? car l'impression que c'est inutile
        public void AjouterMotTrouveInList(Mot mot)
        {
            this.listeMotsTrouves.Add(mot);
        }

        public string toStringListeMotsTrouves()
        {
            string liste = "";
            foreach (Mot ele in this.listeMotsTrouves)
            {
                liste += $"{ele.toString()} \n";
            }
            return liste;
        }


        public int Comptage_Points()
        {
            int total = 0;
            foreach(Mot mot in this.listeMotsTrouves)
            {
                int taille = mot.Longueur;
                switch (taille)
                {
                    case (<5):
                    total+=1;
                    break;

                    case(5):
                        total+=2;
                    break;

                    case (6):
                    total+=3;
                    break;

                case (7):
                    total+=5;
                    break;

                case (>=8):
                    total+=11;
                    break;

                //manque le default
                
                
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

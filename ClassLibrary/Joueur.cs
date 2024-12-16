﻿using System;
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
        int score;

        #endregion

        #region Constructeurs

        public Joueur(string pseudo1)
        {
            this.pseudo = pseudo1;
            this.listeMotsTrouves = new List<Mot>();
        }

        public Joueur(string pseudo1, List<Mot> listeMotTrouves1, int compteurBonsMots1, int compteurMauvaisMots1, int score)
        {
            this.pseudo = pseudo1;
            this.listeMotsTrouves = listeMotTrouves1 ?? new List<Mot>();
            this.compteurBonsMots = compteurBonsMots1;
            this.compteurMauvaisMots = compteurMauvaisMots1;
            this.score=score;
        }
        #endregion

        

        #region Propriétés

        public string Pseudo
        { get { return this.pseudo; } }

        public TimeSpan TempsRestant
        { get { return this.tempsRestant; } set { this.tempsRestant = value; } }

        public List<Mot> ListeMotsTrouves
        { get { return this.listeMotsTrouves; } }
        
        public int Score
        {
            get { return this.score; }
            set { score=value; }
        }

        #endregion

        #region Méthodes
        ////////////////////////////////
        ///Timer joueurs à bouger ici///
        /////////////////////////////////
        

        //utiliser où ? car l'impression que c'est inutile
        public void AddMot(Mot mot)
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
        public int ComptagePointsParPoids(bool estValide, string saisie, Dictionary<char, int> valeursLettres)
        {
            int points = 0;
            if (estValide)
            {
                foreach (char lettre in saisie.ToUpper())
                {
                    if (valeursLettres.ContainsKey(lettre))
                    {
                        points += valeursLettres[lettre];
                    }
                }
            }
            return points;
        }
        public int ComptagePointsParLongueur()
        {
            int total = 0;
            foreach (Mot word in this.listeMotsTrouves)
            {
                int taille = word.Longueur;
                switch (taille)
                {
                    case (< 5):
                        total += 1;
                        break;
                    case (5):
                        total += 2;
                        break;
                    case (6):
                        total += 3;
                        break;
                    case (7):
                        total += 5;
                        break;
                    case (>= 8):
                        total += 11;
                        break;
                }
            }
            return total;
        }
        public static void Gagnant(Joueur p1,Joueur p2)
        {
            if (p1.Score>p2.Score)
            {
                Console.WriteLine(p1.pseudo+" a gagné(e) la partie! Bien joué à tous!");
            }
            if (p2.Score>p1.Score)
            {
                Console.WriteLine(p2.pseudo+" a gagné(e) la partie! Bien joué à tous!");
            }
        }

        // pas testée
        public string toString()
        {
            return $"Le joueur {this.pseudo} a {this.score} points et a trouvé {this.listeMotsTrouves.Count()} mots.";
        }
        #endregion
    }
}

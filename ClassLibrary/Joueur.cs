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
            this.listeMotsTrouves = new List<Mot>(); //sécurité car nulle au début
        }

        public Joueur(string pseudo1, List<Mot> listeMotTrouves1, int compteurBonsMots1, int compteurMauvaisMots1, int score)
        {
            this.pseudo = pseudo1;
            this.listeMotsTrouves = listeMotTrouves1 ?? new List<Mot>(); //sécurité car nulle au début
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
        public void AjouterMotTrouveDansList(Mot mot)
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
        #endregion
    }
}

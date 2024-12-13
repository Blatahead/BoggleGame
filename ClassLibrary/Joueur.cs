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


        #endregion
    }

}

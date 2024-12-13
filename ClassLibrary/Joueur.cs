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

        

        #endregion
    }

}

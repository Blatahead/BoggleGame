using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mot
    {
        #region Attributs
        bool bon;
        int points;
        string valeur;
        char premiereLettre;
        int longueur;
        #endregion

        #region Proprietes
        public bool Bon { get { return this.bon; } }
        public int Points { get { return this.points; } }
        public string Valeur { get { return this.valeur; } }
        public char PremiereLettre {get{return this.premiereLettre;} }
        public int Longueur { get { return this.longueur;} }
        #endregion

        #region Constructeur
        public Mot(bool bon1, string valeur1, int points1, char premiereLettre1, int longueur1)
        {
            this.bon = bon1;
            this.valeur = valeur1;
            this.points = points1;
            this.premiereLettre = premiereLettre1;
            this.longueur = longueur1;
        }


        #endregion

        #region Methodes

        public string toString()
        {
            //if (!this.bon)
            //{
            //    return "Mot invalide";
            //}

            return $"{this.valeur} (Bon : {this.bon}, Points : {this.points}, Longueur : {this.longueur}, Première lettre : {this.premiereLettre})";
        }

        public bool Egale(Mot mot2)
        {
            return (this.valeur == mot2.Valeur) && (this.longueur == mot2.Longueur) 
                && (this.points == mot2.Points);
        }
        public static List<string> ListeDeMotsEnListeDeString(List<Mot> listeMots)
        {
            return listeMots.Select(m => m.Valeur).ToList();
        }
        #endregion
    }
}

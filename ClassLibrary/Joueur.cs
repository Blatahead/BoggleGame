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
        int score;
        #endregion

        #region Constructeurs
        public Joueur(string pseudo1)
        {
            this.pseudo = pseudo1;
            this.listeMotsTrouves = new List<Mot>();
        }

        public Joueur(string pseudo1, List<Mot> listeMotTrouves1, int score)
        {
            this.pseudo = pseudo1;
            this.listeMotsTrouves = listeMotTrouves1 ?? new List<Mot>();
            this.score=score;
        }
        #endregion

        #region Propriétés
        public string Pseudo
        { get { return this.pseudo; } }

        public List<Mot> ListeMotsTrouves
        { get { return this.listeMotsTrouves; } }
        
        public int Score
        { get { return this.score; } set { score=value; } }
        #endregion

        #region Méthodes        
        /// <summary>
        /// Permet d'ajouter un Mot à la liste de mot trouvé du joueur
        /// </summary>
        /// <param name="mot"></param>
        public void AddMot(Mot mot)
        {
            this.listeMotsTrouves.Add(mot);
        }

        /// <summary>
        /// Retourne une string de tous les mots trouvé par le joueur
        /// </summary>
        /// <returns></returns>
        public string toStringListeMotsTrouves()
        {
            string liste = "";
            foreach (Mot ele in this.listeMotsTrouves)
            {
                liste += $"{ele.toString()} \n";
            }
            return liste;
        }

        /// <summary>
        /// Calcule les poids de tous les caractères de tous les bons mots entrés par le jouur.
        /// Ajoute ces points au score du joueur.
        /// </summary>
        /// <param name="estValide"></param>
        /// <param name="saisie"></param>
        /// <param name="valeursLettres"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Calcule la longueur de tous les mots valides entrés par le joueur.
        /// Ajoute ces points au score du joueur en fin de partie.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Affiche les informations du joueur (pseudo, score, liste des mots trouvés)
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            return $"Le joueur {this.pseudo} a {this.score} points et a trouvé {this.listeMotsTrouves.Count()} mots.";
        }
        #endregion
    }
}

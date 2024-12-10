//using BoggleGameWinForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Plateau
    {
        #region Attributs

        De[,] matrice;
        int taille;

        #endregion

        #region Proprietes

        public De[,] Matrice 
        {
            get {return this.matrice; }
            set {this.matrice = value; }
        }
        public int Taille 
        { 
            get { return this.taille; }
            set { this.taille = value; }
        }

        #endregion

        #region Constructeur

        public Plateau(int taille1, string fichierConfigLetttres)
        {
            this.taille = taille1;
            this.matrice = new De[taille1, taille1];
            RemplirPlateau(fichierConfigLetttres);
        }

        #endregion

        #region Méthodes

        private void RemplirPlateau(string fichierConfigLetttres)
        {
            var dicoConfigLettres = ChargerDicoConfigLettres(fichierConfigLetttres);

            var lettresDisponibles = dicoConfigLettres.Keys.ToList();

            Random random = new Random();

            // Générer un dé pour chaque case du plateau
            for (int i = 0; i < this.taille; i++)
            {
                for (int j = 0; j < this.taille; j++)
                {
                    this.matrice[i, j] = new De(dicoConfigLettres, lettresDisponibles, random);
                }
            }
        }

        private Dictionary<char, int> ChargerDicoConfigLettres(string cheminFichier)
        {
            if (!File.Exists(cheminFichier))
            {
                throw new FileNotFoundException($"Fichier introuvable : {cheminFichier}");
            }

            var dicoConfigLettres = new Dictionary<char, int>();

            foreach (string ligne in File.ReadAllLines(cheminFichier))
            {
                var parties = ligne.Split(';');
                if (parties.Length != 3 || !char.IsLetter(parties[0][0]) || !int.TryParse(parties[2], out int maxApparitions) || maxApparitions <= 0)
                {
                    throw new FormatException($"Ligne mal formatée : {ligne}");
                }

                char lettre = parties[0][0];
                dicoConfigLettres[lettre] = maxApparitions;
            }

            return dicoConfigLettres;
        }

        //////////////////////////
        /// A voir si on garde ///
        //////////////////////////
        public char[,] RecupFacesVisibles()
        {
            char[,] facesVisibles = new char[this.taille, this.taille];
            for (int i = 0; i < this.taille; i++)
            {
                for (int j = 0; j < this.taille; j++)
                {
                    facesVisibles[i, j] = this.matrice[i, j].FaceVisible;
                }
            }
            return facesVisibles;
        }

        ///////////////////////
        /// Ne pas ovveride ///
        ///////////////////////
        public string toString()
        {
            string lignes = "";
            for (int i = 0; i < this.taille; i++)
            {
                for (int j = 0; j < this.taille; j++)
                {
                    lignes += $"{this.matrice[i, j].FaceVisible}";
                }
                lignes += "\n";
            }
            return lignes;
        }

        #endregion
    }
}

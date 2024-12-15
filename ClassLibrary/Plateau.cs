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

        //peut-être à faire dans la classe dico
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

        //A déplacere peut-être dans la classe dico
        public static Dictionary<char, int> ChargerDicoValeursLettres(string cheminFichier)
        {
            if (!File.Exists(cheminFichier))
            {
                throw new FileNotFoundException($"Fichier introuvable : {cheminFichier}");
            }

            var dicoValeursLettres = new Dictionary<char, int>();

            foreach (string ligne in File.ReadAllLines(cheminFichier))
            {
                var parties = ligne.Split(';');
                if (parties.Length >= 2 && char.IsLetter(parties[0][0]) && int.TryParse(parties[1], out int valeur))
                {
                    dicoValeursLettres[parties[0][0]] = valeur;
                }
            }

            return dicoValeursLettres;
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

        public bool TestPlateau(string mot)
        {
            if((mot == null) || (mot.Length <=0) ||
                (mot.Length > (this.Taille*this.Taille))) return false;
            for (int i = 0; i < this.taille; i++)
            {
                for (int j = 0; j < this.taille; j++)
                {
                    bool[,] visited = new bool[this.taille, this.taille];

                    if (ChercherMotRecursif(mot, 0, i, j, visited))
                    {
                        return true;
                    }
                }
            }
            return false; 
        }

        // Méthode récursive pour rechercher dans les 8 directions
        private bool ChercherMotRecursif(string mot, int index, int x, int y, bool[,] visited)
        {
            // Condition d'arrêt : le mot complet a été trouvé
            if (index == mot.Length)
            {
                return true;
            }

            // Vérifier si les coordonnées sont valides et si la case est déjà visitée
            if (x < 0 || y < 0 || x >= this.taille || y >= this.taille || visited[x, y])
            {
                return false;
            }

            // Vérifier si la lettre actuelle correspond
            if (this.matrice[x, y].FaceVisible != mot[index])
            {
                return false;
            }

            // Marquer cette case comme visitée
            visited[x, y] = true;

            // Définir les 8 directions (haut, bas, gauche, droite et diagonales)
            int[] directionsX = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] directionsY = { -1, 0, 1, -1, 1, -1, 0, 1 };

            // Explorer les 8 directions
            for (int d = 0; d < 8; d++)
            {
                int newX = x + directionsX[d];
                int newY = y + directionsY[d];

                if (ChercherMotRecursif(mot, index + 1, newX, newY, visited))
                {
                    return true; // Si une direction mène au mot complet, retourner true
                }
            }

            // Backtracking : Décocher cette case pour d'autres chemins possibles
            visited[x, y] = false;

            return false;
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

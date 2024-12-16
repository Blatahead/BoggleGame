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
        List<char> listeFacesVisibles;
        #endregion

        #region Proprietes
        public De[,] Matrice { get {return this.matrice; } set {this.matrice = value; }}

        public int Taille { get { return this.taille; } set { this.taille = value; }}
        #endregion

        #region Constructeur
        public Plateau(int taille1, string fichierConfigLetttres)
        {
            this.taille = taille1;
            this.matrice = new De[taille1, taille1];
            RemplirPlateau(fichierConfigLetttres);
            this.listeFacesVisibles = RecupListFaceVisibles();
        }
        #endregion

        #region Méthodes

        /// <summary>
        /// Remplir la matrice de Dé d'un plateau depuis le fichier de configuration des lettres
        /// </summary>
        /// <param name="fichierConfigLetttres"></param>
        private void RemplirPlateau(string fichierConfigLetttres)
        {
            Dictionary<char, int> dicoConfigLettres = Dictionnaire.ChargerDicoConfigLettres(fichierConfigLetttres);
            List<char> lettresDisponibles = dicoConfigLettres.Keys.ToList();

            Random random = new Random();

            for (int i = 0; i < this.taille; i++)
            {
                for (int j = 0; j < this.taille; j++)
                {
                    this.matrice[i, j] = new De(dicoConfigLettres, lettresDisponibles, random);
                }
            }
        }

        /// <summary>
        /// Teste la présence d'un mot dans le plateau à l'aide de la méthode ChercheMotRecursif
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public bool TestPlateau(string mot)
        {
            if((mot == null) || (mot.Length <=0) ||
                (mot.Length > (this.Taille*this.Taille))) return false;
            for (int i = 0; i < this.taille; i++)
            {
                for (int j = 0; j < this.taille; j++)
                {
                    bool[,] lettresParcourues = new bool[this.taille, this.taille];

                    if (ChercherMotRecursif(mot, 0, i, j, lettresParcourues))
                    {
                        return true;
                    }
                }
            }
            return false; 
        }

        /// <summary>
        /// Récupère les faces visibles d'un plateau sous forme de liste de charactères
        /// </summary>
        /// <returns></returns>
        public List<char> RecupListFaceVisibles()
        {
            List<char> liste = new List<char>();
            for(int i = 0; i < this.taille; i++)
            {
                for(int j = 0; j < this.taille; j++)
                {
                    liste.Add(this.matrice[i,j].FaceVisible);
                }
            }
            return liste;
        }

        /// <summary>
        /// Méthode récursive qui parcourt le plateau.
        /// Revient en arrière si un chemin ne mène à rien de valide.
        /// </summary>
        /// <param name="mot"></param>
        /// <param name="indice"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="lettresParcourues"></param>
        /// <returns></returns>
        private bool ChercherMotRecursif(string mot, int indice, int x, int y, bool[,] lettresParcourues)
        {
            // condition d'arrêt
            if (indice == mot.Length)
            {
                return true;
            }

            if (x < 0 || y < 0 || x >= this.taille || y >= this.taille || lettresParcourues[x, y])
            {
                return false;
            }

            if (this.matrice[x, y].FaceVisible != mot[indice])
            {
                return false;
            }

            lettresParcourues[x, y] = true;

            // directions côtés et diagonales
            int[] directionsX = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] directionsY = { -1, 0, 1, -1, 1, -1, 0, 1 };

            for (int p = 0; p < 8; p++)
            {
                int nouvX = x + directionsX[p];
                int nouvY = y + directionsY[p];

                if (ChercherMotRecursif(mot, indice + 1, nouvX, nouvY, lettresParcourues))
                {
                    return true;
                }
            }
            // explorer d'autres chemins à partir du cran précédant
            lettresParcourues[x, y] = false;

            return false;
        }

        /// <summary>
        /// Retourne le plateau sous forme de string
        /// </summary>
        /// <returns></returns>
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Plateau
    {
        /// <summary>
        /// Méthode de création de plateau
        /// </summary>
        /// <param name="taille_plateau">taille du plateau renseigné par l'utilisateur</param>
        static int[,] Creation_Plateau(int taille_plateau)
        {
            int[,] mat = null;
            if (taille_plateau > 0)
            {
                mat = new int[taille_plateau, taille_plateau];
            }
            return mat;
        }

    }
}

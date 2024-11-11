using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoggleGame
{
    public class De
    {
        int taille_plateau;


        #region Constructeurs
        public De(int taille_plateau)
        {
            this.taille_plateau = taille_plateau;

        }
        #endregion
        #region Propriétés
        public int Taille_plateau
            {
            get { return this.taille_plateau; }
            }
        #endregion

    }
}


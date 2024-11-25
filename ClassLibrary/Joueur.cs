using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Joueur
    {
        string pseudo;
        int compteur_bon_mot;
        int compteur_mauvais_mot;
        #region Constructeurs
        public Joueur(string pseudo)
        {
            this.pseudo = pseudo;
        }
        #endregion
        #region Propriétés
        public string Pseudo
        { get { return this.pseudo; } }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Mot
    {
        bool bon;
        int points;
        string valeur;
        char premiereLettre;
        int longueur;

        public Mot(bool bon1, string valeur1, int points1, char premiereLettre1, int longueur1)
        {
            this.bon = bon1;
            this.valeur = valeur1;
            this.points = points1;
            this.premiereLettre = premiereLettre1;
            this.longueur = longueur1;
        }
    }
}

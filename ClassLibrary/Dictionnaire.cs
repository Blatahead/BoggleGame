using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoggleGame
{
    /// <summary>
    /// ytftyffu
    /// </summary>
    public class Dictionnaire
    {











        static bool dichotomie(string[] tab, string cherché, int debut, int fin)
        {
            if (debut==fin)
            {
                if (tab[debut]==cherché)
                {
                    return true;
                }
                return false;
            }
            if (tab[debut]==cherché)
            {
                return true;
            }
            int milieu = (debut+fin)/2;

            bool CG = dichotomie(tab, cherché, debut+1, milieu);

            bool CD = dichotomie(tab, cherché, milieu+1, fin);
            if (CD==true || CG==true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
   
}

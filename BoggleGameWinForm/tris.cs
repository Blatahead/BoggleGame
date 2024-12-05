using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoggleGameWinForm
{
    public class tris
    {





        #region Tri Fusion
     
        static void TriFusion(int[] tab, int debut, int fin)
        {
            int milieu;
            if (debut<fin)
            {
                milieu=(debut+fin)/2;
                TriFusion(tab, debut, milieu);
                TriFusion(tab, debut+1, fin);
                Fusion(tab, debut, fin, milieu);
            }

        }
        /// <summary>
        /// Méthodes (Fusion et TriFusion) qui morcellent un tableau en plusieurs sous-tableaux avant de les trier par ordre croissants un par un puis entre eux
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        /// <param name="milieu"></param>
        static void Fusion(int[] tab, int debut, int fin, int milieu)
        {
            int indGauche = milieu-debut+1;
            int indDroite = fin-milieu;
            int[] gauche = new int[indGauche];
            int[] droite = new int[indDroite];

            int ind1 = 0;
            int ind2 = 0;
            for (int i = 0; i<indGauche; i++)
            {
                gauche[i] = tab[i+debut];
            }
            for (int i = 0; i<indDroite; i++)
            {
                droite[i]=tab[i+milieu+1];
            }
            for (int i = debut; i<=fin; i++)
            {
                if ((ind2<indDroite) && (ind1<indGauche))
                {
                    if (gauche[ind1]<=droite[ind2])
                    {
                        tab[i]=gauche[ind1++];
                    }
                    else
                    {
                        tab[i]=droite[ind2++];
                    }
                }
                else if (ind2>=indDroite)
                {
                    tab[i]=gauche[ind1++];
                }
                else if (ind1>=indGauche)
                {
                    tab[i]=droite[ind2++];
                }
            }


        }
        #endregion

        #region Tri bulle


        /// <summary>
        /// Méthode qui trie de manière croissante un tableau d'éléments en inversant ses valeurs décroissantes deux à deux
        /// </summary>
        /// <param name="tab"></param>
        static void Tri_bulle(int[] tab)
        {
            if (tab!=null && tab.Length>0)
            {


                for (int i = 0; i<tab.Length-1; i++)
                {

                    for (int j = 0; j<tab.Length-i; j++)
                    {
                        if (tab[j]>tab[j+1])
                        {
                            int temporaire = tab[j];
                            tab[j]=tab[j+1];
                            tab[j+1]=temporaire;


                        }
                    }

                }
            }
        }
            #endregion


          #region tri Insertion
       /// <summary>
       /// Méthode qui trie dans l'ordre croissante en comparant chaque valeur à celles à sa gauche  
       /// </summary>
       /// <param name="tab"></param>
         static void Tri_Insertion(int[] tab)
         {
              if (tab!=null && tab.Length>0)
              {
                 int taille = tab.Length;
                 for (int i = 0; i<taille; i++)
                 {
                     int temporaire = tab[i];
                     int v = i-1;
                     while (v>=0 && tab[v]>temporaire)
                     {
                         tab[v+1]=tab[v];
                         v--;

                     }
                     tab[v+1]=temporaire;
                 }
              }






         }

            #endregion














        
    }
}

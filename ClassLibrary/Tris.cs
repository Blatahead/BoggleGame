using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Tris
    {
        #region Tri Fusion
        public static void TriFusion(List<string> liste, int debut, int fin)
        {
            if (debut < fin)
            {
                int milieu = (debut + fin) / 2;

                TriFusion(liste, debut, milieu);
                TriFusion(liste, milieu + 1, fin);
                Fusion(liste, debut, fin, milieu);
            }
        }

        /// <summary>
        /// Méthodes (Fusion et TriFusion) qui morcellent un tableau en plusieurs sous-tableaux avant de les trier par ordre croissants un par un puis entre eux
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        /// <param name="milieu"></param>
        public static void Fusion(List<string> liste, int debut, int fin, int milieu)
        {
            int tailleGauche = milieu - debut + 1;
            int tailleDroite = fin - milieu;

            List<string> gauche = new List<string>(tailleGauche);
            List<string> droite = new List<string>(tailleDroite);

            for (int i = 0; i < tailleGauche; i++)
                gauche.Add(liste[debut + i]);

            for (int i = 0; i < tailleDroite; i++)
                droite.Add(liste[milieu + 1 + i]);

            // Fusion par remontée des "feuilles"
            int indexGauche = 0, indexDroite = 0;
            int indexListe = debut;

            while (indexGauche < tailleGauche && indexDroite < tailleDroite)
            {
                if (string.Compare(gauche[indexGauche], droite[indexDroite], StringComparison.Ordinal) <= 0)
                {
                    liste[indexListe] = gauche[indexGauche];
                    indexGauche++;
                }
                else
                {
                    liste[indexListe] = droite[indexDroite];
                    indexDroite++;
                }
                indexListe++;
            }

            // éléments restants de gauche
            while (indexGauche < tailleGauche)
            {
                liste[indexListe] = gauche[indexGauche];
                indexGauche++;
                indexListe++;
            }

            // éléments restants de droite
            while (indexDroite < tailleDroite)
            {
                liste[indexListe] = droite[indexDroite];
                indexDroite++;
                indexListe++;
            }
        }

        #endregion

        #region Tri bulle
        /// <summary>
        /// Méthode qui trie de manière croissante un tableau d'éléments en inversant ses valeurs décroissantes deux à deux
        /// </summary>
        /// <param name="tab"></param>
        public static void Tri_bulle(int[] tab)
        {
            if (tab != null && tab.Length > 0)
            {


                for (int i = 0; i < tab.Length - 1; i++)
                {

                    for (int j = 0; j < tab.Length - i; j++)
                    {
                        if (tab[j] > tab[j + 1])
                        {
                            int temporaire = tab[j];
                            tab[j] = tab[j + 1];
                            tab[j + 1] = temporaire;


                        }
                    }
                }
            }
        }
        #endregion

        #region tri Insertion
        /// <summary>
        /// Méthode qui trie dans l'ordre croissante en comparant un pivot aux autres valeurs 
        /// </summary>
        /// <param name="tab"></param>
        public static void Tri_Insertion(int[] tab)
        {
            if (tab != null && tab.Length > 0)
            {
                int taille = tab.Length;
                for (int i = 0; i < taille; i++)
                {
                    int temporaire = tab[i];
                    int v = i - 1;
                    while (v >= 0 && tab[v] > temporaire)
                    {
                        tab[v + 1] = tab[v];
                        v--;

                    }
                    tab[v + 1] = temporaire;
                }
            }
        }
        #endregion
    }
}

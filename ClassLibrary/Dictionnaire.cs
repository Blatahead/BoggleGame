using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{ 
    public class Dictionnaire
    {
        #region Attributs
        SortedList<char,SortedList<int,List<string>>> sortedList;
        string langueDico;
        #endregion

        #region Proprietes
        public SortedList<char, SortedList<int, List<string>>> SortedList
        { get { return this.sortedList; } set { this.sortedList = value; } }

        public string LangueDico
        { get { return this.langueDico; } }
        #endregion

        #region Constructeur
        public Dictionnaire(string langueDico1, SortedList<char,SortedList<int,List<string>>> sortedList1)
        {
            this.langueDico= langueDico1;
            this.sortedList = sortedList1;
        }

        public Dictionnaire(string langueDico1)
        {
            this.langueDico = langueDico1;
            this.sortedList = new SortedList<char, SortedList<int, List<string>>>();
        }
        #endregion


        #region Méthodes
        /// <summary>
        /// Fonction qui permet de lire le bon dictionnaire en fonction de la langue souhaitée.
        /// Stock les mots du dictionnaire dans l'attribut sortedList en fonction des clés
        /// </summary>
        public void Recuperation_Dico()
        {
            try
            {
                string cheminFichier = this.langueDico == "Français"
                    ? "./../../../../MotsPossiblesFR.txt"
                    : "./../../../../MotsPossiblesEN.txt";

                using (StreamReader Dic = new StreamReader(cheminFichier))
                {
                    string line;
                    while ((line = Dic.ReadLine()) != null)
                    {
                        foreach (string mot in line.Split(' '))
                        {
                            if (string.IsNullOrWhiteSpace(mot)) continue;

                            string motNettoye = mot.Trim().ToUpper();
                            char premiereLettre = motNettoye[0];

                            if (!this.sortedList.ContainsKey(premiereLettre))
                            {
                                this.sortedList[premiereLettre] = new SortedList<int, List<string>>();
                            }

                            if (!this.sortedList[premiereLettre].ContainsKey(motNettoye.Length))
                            {
                                this.sortedList[premiereLettre][motNettoye.Length] = new List<string>();
                            }

                            this.sortedList[premiereLettre][motNettoye.Length].Add(motNettoye);
                        }
                    }
                }
                Console.WriteLine("Fichier lu avec succès.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de la lecture du fichier : {e.Message}");
            }
        }

        /// <summary>
        /// Cherche si un mot est présent dans la liste de chemin :
        /// Key = premiereLettre > Key = nombre de lettre dans le mot
        /// </summary>
        /// <param name="liste"></param>
        /// <param name="cherché"></param>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        public static bool RechDichoRecursif(List<string> liste, string cherché, int debut, int fin)
        {
            if (debut > fin) // Cas de base : indices invalides
            {
                return false;
            }

            int milieu = (debut + fin) / 2;

            if (liste[milieu] == cherché) // Mot trouvé
            {
                return true;
            }

            bool CG = RechDichoRecursif(liste, cherché, debut, milieu - 1);

            bool CD = RechDichoRecursif(liste, cherché, milieu + 1, fin);

            return CG || CD;
        }

        /// <summary>
        /// Affiche les clés de la grande sortedList d'un dictionnaire
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            string sortie = "";
            foreach(KeyValuePair<char,SortedList<int, List<string>>> val in this.sortedList)
            {
                sortie += $"{val.Key}\n";
            }
            return sortie;
        }
        #endregion
    }
}
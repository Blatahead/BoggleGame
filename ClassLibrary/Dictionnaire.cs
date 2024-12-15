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
        }
        #endregion


        #region Méthodes
        /// <summary>
        /// Fonction qui permet de lire le bon dictionnaire en fonction de la langue souhaitée
        /// </summary>
        public void Recuperation_Dico()
        {
            string line;
            try
            {
                StreamReader Dic;
                char[] separateur = { ' ' };
                if (this.langueDico=="Français")
                {
                    Dic = new StreamReader("./../../../../MotsPossiblesFR.txt");

                }
                else
                {
                    Dic = new StreamReader("./../../../../MotsPossiblesEN.txt");
                }
                line= Dic.ReadLine();
                string[] s = line.Split(separateur);
                foreach(string s2 in s)
                {
                    SortedList<int, List<string>> tempo = new SortedList<int, List<string>>() ;
                    List<string> mot = new List<string>();
                    mot.Add(s2);
                    tempo.Add(s2.Length, mot);
                    this.sortedList.Add(s2[0],tempo);
                }

                while (line!=null)
                {
                    line=Dic.ReadLine();
                }
                Dic.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : "+e.Message);
            }
            finally
            {
                Console.WriteLine("Fichier lu.");
            }
        }
        public static bool RechDichoRecursif(List<string> liste, string cherché, int debut, int fin)
        {
            if (debut>=fin)
            {
                if (liste[debut]==cherché)
                {
                    return true;
                }
                return false;
            }
         
            int milieu = (debut+fin)/2;
            if (liste[milieu]==cherché)
            {
                return true;
            }
            bool CG = RechDichoRecursif(liste, cherché, debut, milieu-1);

            bool CD = RechDichoRecursif(liste, cherché, milieu+1, fin);
            if (CD==true || CG==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //mettre un return type string (pas de console.writeline)
        public void toString()
        { 
            foreach(KeyValuePair<char,SortedList<int, List<string>>> val in this.sortedList)
            {
                Console.WriteLine(val.Key);
            }
        }
        #endregion
    }
}

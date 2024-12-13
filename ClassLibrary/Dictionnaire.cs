﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{ 
    public class Dictionnaire
    {

        SortedList<char,SortedList<int,List<string>>> Sortedlist1;
        string langue_Dico;

        #region Constructeur
        public Dictionnaire(string langue_Dico, SortedList<char,SortedList<int,List<string>>> list)
        {
            this.langue_Dico=langue_Dico;
            this.Sortedlist1=list;
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
                if (this.langue_Dico=="Français")
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
                    Sortedlist1.Add(s2[0],tempo);
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
        public void toString()
        { 

            foreach(KeyValuePair<char,SortedList<int, List<string>>> val in this.Sortedlist1)
            {
                Console.WriteLine(val.Key);
                
            }
            

        }
         












        #endregion













        public static bool dichotomie(string[] tab, string cherché, int debut, int fin)
        {
            if (debut>=fin)
            {
                if (tab[debut]==cherché)
                {
                    return true;
                }
                return false;
            }
         
            int milieu = (debut+fin)/2;
            if (tab[milieu]==cherché)
            {
                return true;
            }
            bool CG = dichotomie(tab, cherché, debut, milieu-1);

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

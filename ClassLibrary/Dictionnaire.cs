using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    /// <summary>
    /// ytftyffu
    /// </summary>
    public class Dictionnaire
    {

        SortedList<string,SortedList<string,string>> list;
        string langue_Dico;


        public Dictionnaire(string langue_Dico, SortedList<string,SortedList<string,string>> list)
        {
            this.langue_Dico=langue_Dico;
            this.list=list;
        }

        public void Recuperation_Dico()
        {
            string line;
            try
            {
                StreamReader Dic;
                if (this.langue_Dico=="Français")
                {
                     Dic = new StreamReader("./../../../../MotsPossiblesFR.txt");

                }
                else
                {
                     Dic = new StreamReader("./../../../../MotsPossiblesEN.txt");
                }
                line= Dic.ReadLine();
                while (line!=null)
                {
                    line=Dic.ReadLine();
                }
                Dic.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception : "+e.Message);
            }
            finally
            {
                Console.WriteLine("Fichier lu.");
            }






        }













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

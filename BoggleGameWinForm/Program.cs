using BoggleGameWinForm;
using System.Diagnostics;

namespace BoggleGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Accueil());        
        }
        /// <summary>
        /// Méthode de création de plateau
        /// </summary>
        /// <param name="taille_plateau">taille du plateau renseigné par l'utilisateur</param>

        static int[,] Creation_Plateau(int taille_plateau)
        {
            int[,] mat = null;
            if (taille_plateau > 0)
            {
                mat = new int[taille_plateau, taille_plateau];
            }
            return mat;

        }
        static void Temps_de_partie()
        {
            DateTime timer = DateTime.Now;
            TimeSpan durée = TimeSpan.FromMinutes(6);
            while (true)
            {
                TimeSpan elapsed = DateTime.Now - timer;
                Console.Clear();
                Console.WriteLine("Temps écoulée: "+elapsed.Seconds+"secondes");

                if (elapsed<durée)
                {
                    Console.WriteLine("Votre tour est terminé!");
                    break;
                }
            }
        }
    }
}
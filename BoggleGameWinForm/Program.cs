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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Accueil());

            Console.WriteLine("Le jeu du Boggle");
            Console.WriteLine();
            Console.WriteLine("Explications:");
            Console.WriteLine("Chacun son tour, les joueurs vont essayer de réaliser des mots dans un temps imparti sur différents plateaux. \nEn fonction du type de lettres, un joueur peut gagner plus ou moins de point (interdiction de repasser sur les mêmes lettres!).\nEnfin, la partie est terminée après 6 minutes.");
            
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
    }
}
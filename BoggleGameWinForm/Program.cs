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
            Console.WriteLine("Chacun son tour, les joueurs vont essayer de r�aliser des mots dans un temps imparti sur diff�rents plateaux. \nEn fonction du type de lettres, un joueur peut gagner plus ou moins de point (interdiction de repasser sur les m�mes lettres!).\nEnfin, la partie est termin�e apr�s 6 minutes.");
            
        }
        /// <summary>
        /// M�thode de cr�ation de plateau
        /// </summary>
        /// <param name="taille_plateau">taille du plateau renseign� par l'utilisateur</param>

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
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
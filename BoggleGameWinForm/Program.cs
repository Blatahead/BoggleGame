using BoggleGameWinForm;
using System.Diagnostics;

namespace BoggleGame
{
    internal static class Program
    {
        /// <summary>
        ///  Entree principale du jeu
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Accueil());        
        }
    }
}
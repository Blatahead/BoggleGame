using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ClassLibrary
{

    //class Nuage
    //{
    //    private Dictionary<string, int> _frequences;

    //    public Nuage(List<string> Ensemble_Mots)
    //    {
    //        _frequences = CalculerFrequences(Ensemble_Mots);
    //    }

    //    private Dictionary<string, int> CalculerFrequences(List<string> mots)
    //    {
    //        return mots.GroupBy(m => m)
    //                   .ToDictionary(g => g.Key, g => g.Count());
    //    }

    //    public void AfficherNuage()
    //    {
    //        foreach (var mot in _frequences.OrderByDescending(kvp => kvp.Value))
    //        {
    //            int taillePolice = Math.Min(10 + mot.Value * 5, 50); // Taille dynamique
    //            Console.WriteLine($"{mot.Key} (taille: {taillePolice})");
    //        }
    //    }

    //    public void GenererImageNuage(string cheminFichier, int largeur, int hauteur)
    //    {
    //        using (Bitmap bitmap = new Bitmap(largeur, hauteur))
    //        using (Graphics graphics = Graphics.FromImage(bitmap))
    //        {
    //            graphics.Clear(Color.White);
    //            Random rand = new Random();

    //            foreach (var mot in _frequences)
    //            {
    //                int taillePolice = Math.Min(10 + mot.Value * 5, 50);
    //                using (Font font = new Font("Arial", taillePolice))
    //                {
    //                    var position = new Point(rand.Next(0, largeur - 100), rand.Next(0, hauteur - 50));
    //                    graphics.DrawString(mot.Key, font, Brushes.Black, position);
    //                }
    //            }

    //            bitmap.Save(cheminFichier);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<string> Ensemble_Mots = new List<string> { "C#", "nuage", "mots", "programmation", "C#", "nuage", "classe", "nuage", "code" };

    //        Nuage nuage = new Nuage(Ensemble_Mots);
    //        nuage.AfficherNuage();

    //        string cheminFichier = "nuage_de_mots.png";
    //        nuage.GenererImageNuage(cheminFichier, 800, 600);

    //        Console.WriteLine($"Nuage de mots enregistré sous : {cheminFichier}");
    //    }
    //}
}



//Explications
//Classe Nuage :

//La classe contient un dictionnaire _frequences qui stocke chaque mot et son nombre d'occurrences.
//La méthode CalculerFrequences utilise LINQ pour calculer la fréquence des mots.
//Affichage texte du nuage :

//La méthode AfficherNuage imprime les mots avec une taille de police relative à leur fréquence.
//Génération d'image :

//La méthode GenererImageNuage crée une image PNG où chaque mot est dessiné avec une taille de police basée sur sa fréquence.
//Un Random est utilisé pour positionner les mots de manière aléatoire.
//Exemple dans Main:

//Une liste de mots est donnée.
//Le nuage est affiché dans la console et sauvegardé en tant qu’image.
//Ce code génère un nuage de mots visuel et textuel adapté à vos besoins. Vous pouvez le personnaliser pour ajouter plus d'options graphiques.

//IMPORTANT (Pour Antonin car je sais pas faire je suis teuteu). Comme tu l'auras remarqué, "Bitmap" et "Graphics" ne sont pas reconnues dans "System.Drawing".
//Pour résoudre ce problème:
//Le problème vient du fait que l'espace de noms System.Drawing n'est pas entièrement pris en charge dans certains contextes .NET modernes (comme .NET Core ou .NET 5/6/7). Voici les étapes pour résoudre ce problème :

//1.Ajouter la bibliothèque appropriée
//Pour utiliser Bitmap et Graphics, vous devez installer le package NuGet System.Drawing.Common. Pour cela :

//Ouvrez le gestionnaire de packages NuGet de votre projet.
//Installez System.Drawing.Common via NuGet :
// dotnet add package System.Drawing.Common



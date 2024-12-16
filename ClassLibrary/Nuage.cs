using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace ClassLibrary
{

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;

    namespace ClassLibrary
    {
        public class Nuage
        {
            private Dictionary<string, int> _frequences;

            public Nuage(List<string> Ensemble_Mots)
            {
                _frequences = CalculerFrequences(Ensemble_Mots);
            }

            private Dictionary<string, int> CalculerFrequences(List<string> mots)
            {
                return mots.GroupBy(m => m)
                           .ToDictionary(g => g.Key, g => g.Count());
            }

            public void GenererImageNuage(string cheminFichier, int largeur, int hauteur)
            {
                using (Bitmap bitmap = new Bitmap(largeur, hauteur))
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.White);
                    Random rand = new Random();
                    List<Rectangle> zonesOccupees = new List<Rectangle>();

                    foreach (KeyValuePair<string,int> mot in _frequences.OrderByDescending(kvp => kvp.Value))
                    {
                        int taillePolice = Math.Min(10 + mot.Value * 5, 50);
                        using (Font font = new Font("Arial", taillePolice))
                        {
                            SizeF tailleMot = graphics.MeasureString(mot.Key, font);
                            Rectangle rectMot;
                            int essais = 0;

                            do
                            {
                                int x = rand.Next(0, largeur - (int)tailleMot.Width);
                                int y = rand.Next(0, hauteur - (int)tailleMot.Height);
                                rectMot = new Rectangle(x, y, (int)tailleMot.Width, (int)tailleMot.Height);
                                essais++;

                                if (essais > 100) break;

                            } while (zonesOccupees.Any(zone => zone.IntersectsWith(rectMot)));

                            if (essais <= 100)
                            {
                                graphics.DrawString(mot.Key, font, Brushes.Black, rectMot.Location);
                                zonesOccupees.Add(rectMot);
                            }
                        }
                    }

                    bitmap.Save(cheminFichier);
                }
            }

            public static List<string> TrouverTousLesMotsValides(Plateau plateau, Dictionnaire dictionnaire)
            {
                List<string> motsValides = new List<string>();

                foreach (KeyValuePair<char,SortedList<int, List<string>>> entree in dictionnaire.SortedList)
                {
                    char lettre = entree.Key;
                    foreach (KeyValuePair<int,List<string>> listeParLongueur in entree.Value)
                    {
                        foreach (string mot in listeParLongueur.Value)
                        {
                            if (plateau.TestPlateau(mot))
                            {
                                motsValides.Add(mot);
                            }
                        }
                    }
                }

                return motsValides.Distinct().ToList();
            }

            public static void GenererNuageDepuisPlateau(string cheminFichier, Plateau plateau, Dictionnaire dictionnaire)
            {
                List<string> motsValides = TrouverTousLesMotsValides(plateau, dictionnaire);

                if (motsValides.Count > 0)
                {
                    Nuage nuage = new Nuage(motsValides);
                    nuage.GenererImageNuage(cheminFichier, 1800, 1100);
                    Console.WriteLine($"Nuage de mots enregistré sous : {cheminFichier}");
                }
                else
                {
                    Console.WriteLine("Aucun mot valide trouvé sur le plateau.");
                }
            }
        }
    }
}
using ClassLibrary;
using System.Diagnostics;

namespace ClassLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
         public void Test_dico()
         {
            Assert.IsTrue(File.Exists("./../../../../MotsPossiblesFR.txt"), "Le fichier des mots français devrait exister.");
            Assert.IsTrue(File.Exists("./../../../../MotsPossiblesEN.txt"), "Le fichier des mots anglais devrait exister.");
         }

        [TestMethod]
        public void dichotomie_element_existant()
        {

            List<string> liste = ["a", "b", "c", "d", "e"];
            string cherché = "c";
            bool resultat = Dictionnaire.RechDichoRecursif(liste, cherché, 0, liste.Count()- 1);
            Assert.IsTrue(resultat);
        }

        [TestMethod]
        public void dichotomie_nonexistant()
        {
            List<string> liste = ["a", "b", "c", "d", "e"];
            string cherché = "k";
            bool result = Dictionnaire.RechDichoRecursif(liste, cherché, 0, liste.Count() - 1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void dichotomie_unique()
        {
            List<string> liste = ["a"];
            string cherché = "a";
            bool result = Dictionnaire.RechDichoRecursif(liste, cherché, 0, liste.Count() - 1);
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void tri_selection()
        {
            int[] tab = { 3, 5, 2, 1, 7, 6, 4 };
            Tris.Tri_Insertion(tab);
            int[] trié = { 1, 2, 3, 4, 5, 6, 7 };
            CollectionAssert.AreEqual(trié, tab, "Le tableau vide ne doit pas être modifié");
        }

        [TestMethod]
        public void MotEgalMot()
        {
            Mot mot1 = new Mot(true, "test", 5, 't', 4);
            Mot mot2 = new Mot(true, "test", 5, 't', 4);
            Mot mot3 = new Mot(true, "cest", 5, 'c', 4);

            Assert.IsTrue(mot1.Egale(mot2));
            Assert.IsTrue(!mot1.Egale(mot3));
        }
        //[TestMethod]
        //public void RecuperationDictionnaire()
        //{
        //    Assert.
        //}

        [TestMethod]
        public void MotExistantDansPlateau_RetourneTrue()
        {
            Plateau plateau = new Plateau(4, "./../../../../Lettres.txt");
            plateau.Matrice = new De[4, 4]
            {
                { new De('C'), new De('T'), new De('C'), new De('D') },
                { new De('E'), new De('E'), new De('G'), new De('H') },
                { new De('I'), new De('S'), new De('C'), new De('C') },
                { new De('G'), new De('T'), new De('I'), new De('I') }
            };

            //string mot = "TEST"; //2e colonne
            //string mot = "CECI"; //diago
            string mot = "CEIGTSETCGCIICHD"; //colonne 1 puis 2 puis 3 puis 4

            bool result = plateau.TestPlateau(mot);

            Assert.IsTrue(result, $"Le mot {mot} existe dans le plateau.");
        }

        [TestMethod]
        public void MotNonExistantDansPlateau_RetourneFalse()
        {
            Plateau plateau = new Plateau(4, "./../../../../Lettres.txt");
            plateau.Matrice = new De[4, 4]
            {
                { new De('C'), new De('T'), new De('C'), new De('D') },
                { new De('E'), new De('E'), new De('G'), new De('H') },
                { new De('I'), new De('S'), new De('C'), new De('C') },
                { new De('G'), new De('T'), new De('I'), new De('I') }
            };

            //string mot = "CEIGTSETCGCIICHDA"; //taille de plateau dépassée
            //string mot = "CEIGTSETCGCIICHA"; //dernière lettre non présente
            //string mot = null;
            string mot = "";

            bool resultat = plateau.TestPlateau(mot);

            Assert.IsFalse(resultat, $"Le mot {mot} n'existe pas dans le plateau.");
        }
        [TestMethod]
        public void MemeLettreRepeteeDansPlateau_RetournTrue()
        {
            Plateau plateau = new Plateau(4, "./../../../../Lettres.txt");
            plateau.Matrice = new De[4, 4]
            {
                { new De('C'), new De('T'), new De('C'), new De('D') },
                { new De('E'), new De('E'), new De('G'), new De('H') },
                { new De('I'), new De('S'), new De('C'), new De('C') },
                { new De('G'), new De('T'), new De('I'), new De('I') }
            };

            string mot = "CEIGG";

            bool resultat = plateau.TestPlateau(mot);

            Assert.IsFalse(resultat, $"Le mot {mot} utilise deux fois la même lettre du plateau");
        }
    }
}
using ClassLibrary;

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

            string[] tab = { "a", "b", "c", "d", "e" };
            string cherché = "c";
            bool result = Dictionnaire.dichotomie(tab, cherché, 0, tab.Length-1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void dichotomie_nonexistant()
        {
            string[] tab = { "a", "b", "c", "d", "e" };
            string cherché = "k";
            bool result = Dictionnaire.dichotomie(tab, cherché, 0, tab.Length-1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void dichotomie_unique()
        {
            string[] tab = {"a"};
            string cherché = "a";
            bool result = Dictionnaire.dichotomie(tab, cherché, 0, tab.Length-1);
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
        
    }
}



using ClassLibrary;

namespace ClassLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
         public void TestMethod1()
         {
            Assert.IsTrue(File.Exists("./../../../../MotsPossiblesFR.txt"), "Le fichier des mots français devrait exister.");
            Assert.IsTrue(File.Exists("./../../../../MotsPossiblesEN.txt"), "Le fichier des mots anglais devrait exister.");


         }
    }
}



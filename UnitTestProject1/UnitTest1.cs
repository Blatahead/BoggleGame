using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ClassLibrary;

namespace BoggleGameWinForm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SortedList<string, SortedList<string, string>> list = new SortedList<string, SortedList<string, string>>();
            Dictionnaire Dico = new Dictionnaire("Français", list);




        }
    }
}

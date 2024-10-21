using PetsAndFleas.ConApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PetsAndFleas.UnitTest
{
        /// <summary>
        ///A test for ClimbOnTree
        ///</summary>
        [TestMethod()]
        public void ClimbOnTreeTest()
        {
            Cat c1 = new Cat();
            bool result;
            result=c1.ClimbOnTree();
            Assert.AreEqual(c1.TreesClimbed, 1, "Katze sollte auf 1 Baum geklettert sein!");
            Assert.AreEqual(result, true, "Katze sollte auf 1 Baum geklettert sein (Rückgabewert daher true erwartet)!");
            result = c1.ClimbOnTree();
            Assert.AreEqual(c1.TreesClimbed, 1, "Katze ist gerade auf einen Baum! Muss vorher runter....");
            Assert.AreEqual(result, false, "Katze ist gerade auf einen Baum! Muss vorher runter....Rückgabewert false erwartet!");
            result = c1.ClimbDown();
            result = c1.ClimbOnTree();
            Assert.AreEqual(c1.TreesClimbed, 2, "Katze ist auf 2 Bäume geklettert");
            Assert.AreEqual(result, true, "true erwartet");
        }
    }
}

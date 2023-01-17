using PetsAndFleas.ConApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PetsAndFleas.UnitTest
{
    
    
    /// <summary>
    ///This is a test class for CatTest and is intended
    ///to contain all CatTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CatTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


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

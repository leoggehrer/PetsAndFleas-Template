using PetsAndFleas.ConApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PetsAndFleas.UnitTest
{
    
    
    /// <summary>
    ///This is a test class for PetTest and is intended
    ///to contain all PetTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PetTest
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
        ///A test for GeneratingPets
        ///</summary>
        [TestMethod()]
        public void GetPetID()
        {
            int startID = Pet.LastPetID;
            Pet p1 = new Cat();
            Pet p2 = new Cat();
            Pet p3 = new Dog();

            Assert.AreEqual(startID+1, p1.PetID, "ID Pet 1 falsch");
            Assert.AreEqual(startID+2, p2.PetID, "ID Pet 2 falsch");
            Assert.AreEqual(startID+3, p3.PetID, "ID Pet 3 falsch");
            p3 = new Cat();
            Assert.AreEqual(startID+4, p3.PetID, "ID Pet 4 falsch");
        }

        /// <summary>
        ///A test for GetBiten
        ///</summary>
        [TestMethod()]
        public void PetGetBitenTest()
        {
            int result;
            Pet p1 = new Cat();
            Pet p2 = new Cat();
            Pet p3 = new Dog();

            Assert.AreEqual(100, p1.RemainingBites, "Remaining Bites falsch initialisiert!");
            Assert.AreEqual(100, p2.RemainingBites, "Remaining Bites falsch initialisiert!");
            Assert.AreEqual(100, p3.RemainingBites, "Remaining Bites falsch initialisiert!");
            result = p1.GetBiten(40);
            Assert.AreEqual(60, p1.RemainingBites, "Nach 40 Bissen sollten 60 übrig sein!");

            result = p1.GetBiten(70);
            Assert.AreEqual(60, result, "Es sind nurmehr 60 übrig daher sollte 60 zurückgegeben werden!");
            Assert.AreEqual(0, p1.RemainingBites, "Alle Bisse sollten aufgebraucht sein!");
            result = p2.GetBiten(200);
            Assert.AreEqual(100, result, "Es sind nur 100 Bisse möglich daher sollte 100 zurückgegeben werden!");
            Assert.AreEqual(0, p2.RemainingBites, "Alle Bisse sollten aufgebraucht sein!");
            result = p3.GetBiten(-100);
            Assert.AreEqual(0, result, "Negative Bissanzahl nicht möglich! 0 als Rückgabewert erwartet!");
            Assert.AreEqual(100, p3.RemainingBites, "Es sollten immer noch 100 Bisse übrig sein!");
        }
    }
}

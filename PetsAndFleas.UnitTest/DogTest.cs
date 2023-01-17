using PetsAndFleas.ConApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace PetsAndFleas.UnitTest
{
    
    
    /// <summary>
    ///This is a test class for DogTest and is intended
    ///to contain all DogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DogTest
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
        ///A test for HuntAnimal
        ///</summary>
        [TestMethod()]
        public void HuntAnimalTest()
        {
            Dog d1 = new Dog();
            bool actual;

            //BEACHTE! Breakpoints im Bereich dieses Unit-Tests können das Ergebnis verfälschen!! (Überlege warum...) 
            actual = d1.HuntAnimal();
            Assert.AreEqual(d1.HuntedAnimals, 1, "Es sollte 1 in HuntedAnimals stehen!");
            Assert.AreEqual(actual, true, "Es sollte true zurückgegeben werden!");
            actual = d1.HuntAnimal(); 
            Assert.AreEqual(d1.HuntedAnimals, 1, "Es sollte immer noch 1 in HuntedAnimals stehen! (Pause zu kurz)");
            Assert.AreEqual(actual, false, "Es sollte false zurückgegeben werden!");
            Thread.Sleep(1001);
            actual = d1.HuntAnimal();
            Assert.AreEqual(d1.HuntedAnimals, 2, "Es sollte nun 2 in HuntedAnimals stehen! (Pause eingehalten)");
            Assert.AreEqual(actual, true, "Es sollte true zurückgegeben werden!");
        }

    }
}

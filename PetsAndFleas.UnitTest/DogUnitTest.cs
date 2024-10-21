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
    public class DogUnitTest
    {
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

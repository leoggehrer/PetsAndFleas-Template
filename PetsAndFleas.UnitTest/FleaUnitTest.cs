using PetsAndFleas.ConApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PetsAndFleas.UnitTest
{
    
    
    /// <summary>
    ///This is a test class for FleaTest and is intended
    ///to contain all FleaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FleaUnitTest
    {
        /// <summary>
        ///A test for BitePet
        ///</summary>
        [TestMethod()]
        public void BitePetTest()
        {
            int result;
            Pet p1 = new Cat();
            Pet p2 = new Cat();
            Pet p3 = new Dog();
            Flea f1 = new Flea();
            Flea f2 = new Flea();
            Flea f3 = new Flea();
            
            f1.JumpOnPet(p1);
            result = f1.BitePet(40);
            Assert.AreEqual(60, p1.RemainingBites, "Nach 40 Bissen sollten 60 übrig sein!");
            result = f1.BitePet(70);
            Assert.AreEqual(60, result, "Es sind nurmehr 60 übrig daher sollte 60 zurückgegeben werden!");
            Assert.AreEqual(100, f1.AmountBites, "Floh 1 sollte 100 Bisse vollzogen haben!");
            Assert.AreEqual(0, p1.RemainingBites, "Alle Bisse sollten aufgebraucht sein!");
            f1.JumpOnPet(p2);
            result = f1.BitePet(150);
            Assert.AreEqual(100, result, "Es sind nur 100 Bisse möglich daher sollte 100 zurückgegeben werden!");
            Assert.AreEqual(200, f1.AmountBites, "Alle Bisse sollten aufgebraucht sein!");
            f2.JumpOnPet(p3);
            result = f2.BitePet(-100);
            Assert.AreEqual(0, result, "Negative Bissanzahl nicht möglich! 0 als Rückgabewert erwartet!");
            Assert.AreEqual(0, f2.AmountBites, "Es sollten immer noch 0 Bisse sein!");
            f1.JumpOnPet(null);
            result = f1.BitePet(100);
            Assert.AreEqual(0, result, "Floh sitzt auf keinem Hund daher sollte 0 zurückgeliefert werden!");
            result = f3.BitePet(100);
            Assert.AreEqual(0, result, "Floh sitzt auf keinem Hund daher sollte 0 zurückgeliefert werden!");
        }

        /// <summary>
        ///A test for JumpOnPet
        ///</summary>
        [TestMethod()]
        public void JumpOnPetTest()
        {
            int startID = Pet.LastPetID;
            Pet p1 = new Cat();
            Pet p2 = new Dog();
            Flea f1 = new Flea();
            Flea f2 = new Flea();
            Flea f3 = new Flea();
            

            f1.JumpOnPet(p1);
            f2.JumpOnPet(p2);
            f3.JumpOnPet(p1);
            Assert.AreEqual(f1.ActualPet.PetID, startID + 1, "Floh 1 sollte auf Pet ID {0} sitzen!", startID+1);
            Assert.AreEqual(f2.ActualPet.PetID, startID + 2, "Floh 2 sollte auf Pet ID {0} sitzen!",startID+2);
            Assert.AreEqual(f3.ActualPet.PetID, startID + 1, "Floh 3 sollte auf Pet ID {0} sitzen!",startID+1);
            f3.JumpOnPet(p2);
            Assert.AreEqual(f3.ActualPet.PetID, startID + 2, "Floh 3 sollte nach Übersprung auf Pet ID {0} sitzen!", startID + 2);
            f3.JumpOnPet(null);
            Assert.AreEqual(f3.ActualPet, null, "Floh 3 sollte nach Absprung auf keinem Pet sitzen!", startID + 2);

        }
    }
}

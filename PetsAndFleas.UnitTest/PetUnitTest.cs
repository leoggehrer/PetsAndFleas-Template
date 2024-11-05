using PetsAndFleas.ConApp;

namespace PetsAndFleas.UnitTest
{
    [TestClass()]
    public class PetUnitTest
    {
        /// <summary>
        /// Tests if a new pet is initialized with 100 remaining bites.
        /// </summary>
        [TestMethod]
        public void ItShouldInitializeWith100RemainingBites_GivenNewPet()
        {
            // Arrange
            Pet p1 = new Cat();
            Pet p2 = new Cat();
            Pet p3 = new Dog();

            // Assert
            Assert.AreEqual(100, p1.RemainingBites, "Remaining Bites von p1 falsch initialisiert!");
            Assert.AreEqual(100, p2.RemainingBites, "Remaining Bites von p2 falsch initialisiert!");
            Assert.AreEqual(100, p3.RemainingBites, "Remaining Bites von p3 falsch initialisiert!");
        }

        /// <summary>
        /// Tests if the remaining bites are reduced correctly given a bite amount.
        /// </summary>
        [TestMethod]
        public void ItShouldReduceRemainingBites_GivenBiteAmount()
        {
            // Arrange
            Pet p1 = new Cat();

            // Act
            int result = p1.GetBiten(40);

            // Assert
            Assert.AreEqual(60, p1.RemainingBites, "Nach 40 Bissen sollten 60 übrig sein!");
        }

        /// <summary>
        /// Tests if the method returns the remaining bites correctly when the bite amount exceeds the remaining bites.
        /// </summary>
        [TestMethod]
        public void ItShouldReturnRemainingBites_GivenBiteAmountExceedingRemainingBites()
        {
            // Arrange
            Pet p1 = new Cat();
            p1.GetBiten(40); // 60 Bisse übrig

            // Act
            int result = p1.GetBiten(70);

            // Assert
            Assert.AreEqual(60, result, "Es sind nur 60 Bisse übrig, daher sollte 60 zurückgegeben werden.");
            Assert.AreEqual(0, p1.RemainingBites, "Alle Bisse von p1 sollten aufgebraucht sein.");
        }

        /// <summary>
        /// Tests if the method returns the maximum remaining bites correctly when the bite amount exceeds the capacity.
        /// </summary>
        [TestMethod]
        public void ItShouldReturnMaxRemainingBites_GivenBiteAmountExceedingCapacity()
        {
            // Arrange
            Pet p2 = new Cat();

            // Act
            int result = p2.GetBiten(200); // Versuche mehr als möglich

            // Assert
            Assert.AreEqual(100, result, "Es sind nur 100 Bisse möglich, daher sollte 100 zurückgegeben werden.");
            Assert.AreEqual(0, p2.RemainingBites, "Alle Bisse von p2 sollten aufgebraucht sein.");
        }

        /// <summary>
        /// Tests if the method throws an ArgumentException given a negative bite amount.
        /// </summary>
        [TestMethod]
        public void ItShouldThrowArgumentException_GivenNegativeBiteAmount()
        {
            // Arrange
            Pet p3 = new Dog();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => p3.GetBiten(-100), "Eine negative Bissanzahl sollte eine ArgumentException auslösen.");
            Assert.AreEqual(100, p3.RemainingBites, "Negative Bissanzahl nicht möglich! 0 als Rückgabewert erwartet.");
        }

        /// <summary>
        /// Tests if the method throws an ArgumentException given a zero bite amount.
        /// </summary>
        [TestMethod]
        public void ItShouldThrowArgumentException_GivenZeroBiteAmount()
        {
            // Arrange
            Pet p3 = new Dog();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => p3.GetBiten(0), "Eine Bissanzahl von 0 sollte eine ArgumentException auslösen.");
        }
    }
}

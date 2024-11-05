using PetsAndFleas.ConApp;

namespace PetsAndFleas.UnitTest
{
    [TestClass()]
    public class DogUnitTest
    {
        /// <summary>
        /// Tests if the first hunt increments the HuntedAnimals count and returns true.
        /// </summary>
        [TestMethod]
        public void ItShouldReturnTrueAndIncrementHuntedAnimals_GivenFirstHunt()
        {
            // Arrange
            Dog d1 = new Dog();

            // Act
            bool actual = d1.HuntAnimal();

            // Assert
            Assert.AreEqual(1, d1.HuntedAnimals, "Es sollte 1 in HuntedAnimals stehen!");
            Assert.AreEqual(true, actual, "Es sollte true zurückgegeben werden!");
        }

        /// <summary>
        /// Tests if the second hunt within a short pause does not increment the HuntedAnimals count and returns false.
        /// </summary>
        [TestMethod]
        public void ItShouldReturnFalseAndNotIncrementHuntedAnimals_GivenSecondHuntWithinShortPause()
        {
            // Arrange
            Dog d1 = new Dog();
            d1.HuntAnimal(); // Erste Jagd

            // Act
            bool actual = d1.HuntAnimal(); // Zweite Jagd direkt danach

            // Assert
            Assert.AreEqual(1, d1.HuntedAnimals, "Es sollte immer noch 1 in HuntedAnimals stehen! (Pause zu kurz)");
            Assert.AreEqual(false, actual, "Es sollte false zurückgegeben werden!");
        }

        /// <summary>
        /// Tests if the hunt after a sufficient pause increments the HuntedAnimals count and returns true.
        /// </summary>
        [TestMethod]
        public void ItShouldReturnTrueAndIncrementHuntedAnimals_GivenHuntAfterSufficientPause()
        {
            // Arrange
            Dog d1 = new Dog();
            d1.HuntAnimal(); // Erste Jagd
            Thread.Sleep(1001); // Pause

            // Act
            bool actual = d1.HuntAnimal(); // Zweite Jagd nach ausreichender Pause

            // Assert
            Assert.AreEqual(2, d1.HuntedAnimals, "Es sollte nun 2 in HuntedAnimals stehen! (Pause eingehalten)");
            Assert.AreEqual(true, actual, "Es sollte true zurückgegeben werden!");
        }
    }
}

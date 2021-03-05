namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class AquariumsTests
    {
       [Test]
        public void ConstructorShouldInicialiseCorrectlyAllProperties()
        {
            Aquarium aquarium = new Aquarium("Za ribi", 4);

            string expectedName = "Za ribi";
            int expectedCapacity = 4;

            Assert.AreEqual(expectedName, aquarium.Name);
            Assert.AreEqual(expectedCapacity, aquarium.Capacity);
        }
        [TestCase("",4)]
        [TestCase(null, 4)]
        public void ConstructorShouldThrowExceptionIfNameIsNullOrEmpty(string name,int capacity)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Aquarium aquarium = new Aquarium(name, capacity);
            });
        }
        [TestCase("Za ribi",-4)]
        public void ConstructorShouldThrowExceptionIfTheGivenValueIsLowerThanZero(string name, int capacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Aquarium aquarium = new Aquarium(name, capacity);
            });
        }
        [Test]
        public void AddShouldAddFishToTheCollection()
        {
            Aquarium aquarium = new Aquarium("Za ribi", 4);
            int expectedCount = 1;

            aquarium.Add(new Fish("Joro"));

            Assert.AreEqual(expectedCount, aquarium.Count);
        }
        [Test]
        public void AddShouldThrowExceptionIfWetryToAddOverTheCapacity()
        {
            Aquarium aquarium = new Aquarium("Za ribi", 1);

            aquarium.Add(new Fish("Joro"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.Add(new Fish("Pesho"));
            });
        }
        [Test]
        public void RemoveFishShouldRemoveFishFromTheCollection()
        {
            Aquarium aquarium = new Aquarium("Za ribi", 1);

            aquarium.Add(new Fish("Joro"));
            aquarium.RemoveFish("Joro");

            Assert.AreEqual(0, aquarium.Count);

        }
        [Test]
        public void RemoveFishShouldThrowExcpetionForInvalidFish()
        {
            Aquarium aquarium = new Aquarium("Za ribi", 1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.RemoveFish("Joro");

            });
        }
        [Test]
        public void SellFishShouldReturnRequestedFish()
        {
            Aquarium aquarium = new Aquarium("Za ribi", 1);

            aquarium.Add(new Fish("Joro"));

            Fish returnedFish = aquarium.SellFish("Joro");

            Assert.AreEqual(returnedFish.Name, "Joro");
        }
        [Test]
        public void SellFishShouldThrowExcpetionIfFishWithThisNameDoesntExist()
        {
            Aquarium aquarium = new Aquarium("Za ribi", 1);

            aquarium.Add(new Fish("Joro"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                Fish returnedFish = aquarium.SellFish("Gosho");
            });
        }
        [Test]
        public void ReportShouldWorkCorrectly()
        {
            Aquarium aquarium = new Aquarium("Za ribi", 1);

            aquarium.Add(new Fish("Joro"));

            string report = aquarium.Report();

            Assert.AreEqual("Fish available at Za ribi: Joro", report);
        }
    }
}

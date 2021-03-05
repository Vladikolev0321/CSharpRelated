namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Diagnostics.Contracts;

    public class PresentsTests
    {
        private Bag bag;
        private Present present;
        [SetUp]
        public void SetUp()
        {
            bag = new Bag();
        }
        [Test]
        public void TestIfCTorPresentWorksCorrectly()
        {
            present = new Present("Joro", 2);

            Assert.AreEqual("Joro", present.Name);
            Assert.AreEqual(2, present.Magic);
        }

        [Test]
        public void CreateShouldAddPresentToTheBag()
        {
            int expectedCount = 1;
            present = new Present("Joro", 2);

            bag.Create(present);

            Assert.AreEqual(expectedCount, bag.GetPresents().Count);
        }
        [Test]
        public void CreateShouldThrowExceptionIfPresontIsNull()
        {
            present = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                bag.Create(present);
            });
        }
        [Test]
        public void CreateShouldThrowExcpetionIfThisPresentAlreadyExists()
        {
            present = new Present("Joro", 2);
            
            bag.Create(present);

            Assert.Throws<InvalidOperationException>(() =>
            {
                bag.Create(present);
            });
        }
        [Test]
        public void RemoveShouldDecreaseCount()
        {
            present = new Present("Joro", 2);

            bag.Create(present);
            bag.Remove(present);

            Assert.AreEqual(0, bag.GetPresents().Count);
            
        }
        [Test]
        public void GetPresentWithLeastMagicReturnsCorrectly()
        {
            present = new Present("Joro", 6);
            Present present1 = new Present("Vlado", 3);
            Present present2 = new Present("Gosho", 5);

            bag.Create(present);
            bag.Create(present1);
            bag.Create(present2);

            Present returnedPresent = bag.GetPresentWithLeastMagic();

            Assert.AreEqual(present1, returnedPresent);

        }
        [Test]
        public void GetPresentShouldReturnPresentWithGivenName()
        {
            present = new Present("Joro", 6);
            Present present1 = new Present("Vlado", 3);
            Present present2 = new Present("Gosho", 5);

            bag.Create(present);
            bag.Create(present1);
            bag.Create(present2);

            Present returnedPresent = bag.GetPresent("Vlado");

            Assert.AreEqual(present1,returnedPresent);
        }

    }
}

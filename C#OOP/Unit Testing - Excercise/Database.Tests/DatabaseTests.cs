using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        private Database.Database database;
        private readonly int[] initialData = new int[] { 1, 2 };
        [SetUp]
        public void Setup()
        {
            this.database = new Database.Database(initialData);
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            int[] data = new int[] { 1, 2, 3 };
            this.database = new Database.Database(data);

            int expectedCount = data.Length;
            int actualCount = this.database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
        [Test]
        public void ConstructorShouldThrowExceptionWhenInitializingWithBiggerCollection()
        {
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9,
                10, 11, 12, 13, 14, 15, 16, 17 };

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database = new Database.Database(data);
            });

        }
        [Test]
        public void AddShouldIncreaseCountWhenAddedSuccesfully()
        {
            this.database.Add(3);

            int expectedCount = 3;
            int actualCount = this.database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
        [Test]
        public void AddShouldThrowExceptionWhenDatabaseFull()
        {
            //1 2 3 4 5 ...16
            for (int i = 3; i <= 16; i++)
            {
                this.database.Add(i);
            }

            //The collection is full 

            Assert.Throws<InvalidOperationException>(() =>
            {
                //Try add 17th item
                this.database.Add(17);
            }); 

        }
        [Test]
        public void RemoveShouldDecreaseCountWhenDecreasedSuccesfully()
        {
            //Arrange
            int expectedCount = 1;

            //Act
            this.database.Remove();

            int actual = this.database.Count;

            //Assert
            Assert.AreEqual(expectedCount, actual);
        }
        [Test]
        public void RemoveShouldThrowExceptionIfIsCollectionEmpty()
        {
            this.database.Remove();
            this.database.Remove();

            //Database.Count = 0

            Assert.Throws<InvalidOperationException>(() =>
            {
                //No items Removed
                this.database.Remove();
            });
        }
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1,2,3,4,5,6,7,8,9
            ,10,11,12,13,14,15,16 })]
        public void FetchShouldReturnCopyOfData(int[] expectedData)
        {
            this.database = new Database.Database(expectedData);

            //Returned copy
            int[] actualData = this.database.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }
    }
}
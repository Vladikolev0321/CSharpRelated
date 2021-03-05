using ExtendedDatabase;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Threading;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private Person gosho;
        private Person pesho;
        private ExtendedDatabase.ExtendedDatabase database;
        [SetUp]
        public void Setup()
        {
            gosho = new Person(447788556699, "Gosho");
            pesho = new Person(114560, "Pesho");
            database = new ExtendedDatabase.ExtendedDatabase(gosho, pesho);
        }

        [Test]
        public void ConstructorShouldInicialise()
        {
            
            var expected = new Person[] { gosho, pesho };
            var actual = expected;

            var database = new ExtendedDatabase.ExtendedDatabase(expected);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AddShouldIncreaseDatabaseCount()
        {
            int expectedCount = 3;

            database.Add(new Person(21323, "Stamo"));
            int actualCount = this.database.Count;

            Assert.AreEqual(expectedCount, actualCount);

        }
        [Test]
        public void AddShouldThrowExceptionIfWeTryToAddMoreThan16People()
        {
            database = new ExtendedDatabase.ExtendedDatabase(gosho, pesho,
                new Person(1323, "tamo"), new Person(13233, "amo"), new Person(132123, "Ramo")
                , new Person(323, "tdmo"), new Person(21, "trmo"), new Person(23, "taqmo")
                , new Person(4, "Gom"), new Person(133, "Tom"), new Person(123, "Seamo")
                , new Person(512, "Feamo"),
                new Person(234, "tadfhjjgmo"), new Person(1315623, "taasdfasmo"), new Person(3455, "tamsdo")
                , new Person(2656, "ryttu"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(new Person(21323, "Stamo"));
            });

        }
        [Test]
        public void AddShouldThrowExceptionIfWeTryToAddAlreadyExistingUsername()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(new Person(23, "Gosho"));
            });
        }
        [Test]
        public void AddShouldThrowExceptionIfWeTryToAddAlreadyExistingId()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(new Person(447788556699, "Gone"));
            });
        }
        [Test]
        public void RemoveShouldDecreaseDatabaseCount()
        {
            int expectedCount = 1;

            database.Remove();

            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
        [Test]
        public void RemoveShouldThrowExceptionIfCountIsZero()
        {
            database = new ExtendedDatabase.ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }
        [Test]
        public void FindByUsernameShouldThrowExceptionIfGivenStringIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                database.FindByUsername("");
            });
        }
        [Test]
        public void FindByUsernameShouldThrowExceptionIfNoUserIsPresentByThisName()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindByUsername("Stamo");
            });
        }
        [Test]
        public void FindByUSerNameShouldReturnValidUser()
        {
            var expected = pesho;

            var actual = database.FindByUsername("Pesho");

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FindByUserNameShouldBeCaseSensitive()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindByUsername("gosho");
            });
        }
        [Test]
        public void FindByIdShouldThrowExceptionIfNegativeIdIsGiven()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                database.FindById(-10);
            });
        }
        [Test]
        public void FindByIdShouldThrowExceptionIfThereIsNotSuchId()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindById(23324);
            });
        }
        [Test]
        public void FindByIdShouldReturnValidUser()
        {
            var expected = pesho;

            var actual = database.FindById(114560);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddRangeThrowExceptionIfYouTryToMakeDatabaseWithMoreThan16People()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                database = new ExtendedDatabase.ExtendedDatabase(gosho, pesho,
                new Person(1323, "tamo"), new Person(13233, "amo"), new Person(132123, "Ramo")
                , new Person(323, "tdmo"), new Person(21, "trmo"), new Person(23, "taqmo")
                , new Person(4, "Gom"), new Person(133, "Tom"), new Person(123, "Seamo")
                , new Person(512, "Feamo"),
                new Person(234, "tadfhjjgmo"), new Person(1315623, "taasdfasmo"), new Person(3455, "tamsdo")
                , new Person(2656, "ryttu"), new Person(256, "Joro"));
            });
        }

    }
}
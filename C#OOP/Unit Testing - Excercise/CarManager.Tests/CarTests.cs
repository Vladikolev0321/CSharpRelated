using CarManager;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorInitEverything()
        {
            string make = "Mercedes";
            string model = "Amg";
            double fuelCons = 3;
            double capacity = 100;

            car = new Car(make, model, fuelCons, capacity);

            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelCons, car.FuelConsumption);
            Assert.AreEqual(capacity, car.FuelCapacity);
        }
        [TestCase("","Amg",3,100)]
        [TestCase("Mercedes", "", 3, 100)]
        [TestCase("Mercedes", "Amg", -3, 100)]
        [TestCase("Mercedes", "Amg", 0, 100)]
        [TestCase("Mercedes", "Amg", 3, 0)]
        [TestCase("Mercedes", "Amg", 3, -100)]
        public void ConstructorInicializingExcpetions(string make, string model,
            double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(make, model, fuelConsumption, fuelCapacity);
            });
        }
        //[Test]
        //public void FuelAmountShouldThrowExceptionIfItsLowerThanZero()
        //{

        //}





        [TestCase(-3)]
        [TestCase(0)]
        public void RefuelShouldThrowExceptionIfItIsGivenZeroOrSmallerNumber(double fuelToRefuel)
        {
            car = new Car("Mercedes", "Amg", 3, 100);

            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(fuelToRefuel);
            });
        }
        [Test]
        public void RefuelShouldIncreaseFuelAmountByGiven()
        {
            car = new Car("Mercedes", "Amg", 3, 100);
            double expectedFuelAmount = 10;

            car.Refuel(10);

            Assert.AreEqual(expectedFuelAmount, car.FuelAmount);
            
        }
        [Test]
        public void RefuelShouldNotIncreaseOverTheCapacity()
        {
            car = new Car("Mercedes", "Amg", 3, 100);
            double expectedFuel = 100;

            car.Refuel(110);

            Assert.AreEqual(expectedFuel, car.FuelAmount);
        }
        [Test]
        public void DriveShouldThrowExceptionIfItDoesntHaveEnoughFuel()
        {
            car = new Car("Mercedes", "Amg", 3, 100);

            Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(23);
            });
        }
        [Test]
        public void DriveShouldDecreaseFuelAmountCorrectly()
        {
            car = new Car("Mercedes", "Amg", 3, 100);
            double expectedFuelLeft = 97;
            car.Refuel(100);

            car.Drive(100);

            Assert.That(expectedFuelLeft, Is.EqualTo(car.FuelAmount));
        }

    }
}

namespace TestDemos1.Test
{
    using NUnit.Framework;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using TestApp1;

    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void SumShouldReturnCorrectResultWithTwoNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateSum(1, 2);

            Assert.AreEqual(3, result);



            //if(result != 3)
            //{
            //    throw new InvalidOperationException
            //        ("SumShouldReturnCorrectResultWithTwoNumbers failed");
            //}
        }

        [Test]
        public void SumShouldReturnCorrectResultWithManyNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateSum(1, 2,3,4,5,6);

            //if (result != 21)
            //{
            //    throw new InvalidOperationException
            //        ("SumShouldReturnCorrectResultWithManyNumbers failed");
            //}

            Assert.AreEqual(21, result);
        }

        [Test]
        public void SumShouldReturnCorrectResultWithNoNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateSum();

            //if (result != 0)
            //{
            //    throw new InvalidOperationException
            //        ("SumShouldReturnCorrectResultWithNoNumbers failed");
            //}
            Assert.AreEqual(0, result);

        }
        [Test]
        public void ProductShouldReturnCorrectResultWithTwoNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.Product(2, 3);

            Assert.AreEqual(6, result);
        }
    }
}

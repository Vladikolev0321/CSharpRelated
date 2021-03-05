
namespace TestDemos.Test
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using TestApp;
    using Xunit;
    public class CalculatorTest
    {
        [Fact]
        public void SumShouldReturnCorrectResultWithTwoNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateSum(1, 2);

            Assert.Equal(3, result);



            //if(result != 3)
            //{
            //    throw new InvalidOperationException
            //        ("SumShouldReturnCorrectResultWithTwoNumbers failed");
            //}
        }

        [Fact]
        public void SumShouldReturnCorrectResultWithManyNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateSum(1, 2,3,4,5,6);

            //if (result != 21)
            //{
            //    throw new InvalidOperationException
            //        ("SumShouldReturnCorrectResultWithManyNumbers failed");
            //}

            Assert.Equal(21, result);
        }

        [Fact]
        public void SumShouldReturnCorrectResultWithNoNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateSum();

            //if (result != 0)
            //{
            //    throw new InvalidOperationException
            //        ("SumShouldReturnCorrectResultWithNoNumbers failed");
            //}
            Assert.Equal(0, result);

        }
        [Fact]
        public void ProductShouldReturnCorrectResultWithTwoNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.Product(2, 3);

            Assert.Equal(6, result);
        }
    }
}

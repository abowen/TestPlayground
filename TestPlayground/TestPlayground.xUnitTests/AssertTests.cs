using System;
using TestPlayground.Business.Entities;
using Xunit;

namespace TestPlayground.xUnitTests
{
    public class AssertTests
    {
        [Fact]
        public void EqualTest()
        {
            // ARRANGE
            var calculator = new Calculator();

            // ACT
            var result = calculator.Add(3, 4);

            // ASSERT
            Assert.Equal(7, result);
        }

        [Fact]
        public void ExceptionTest()
        {
            // ARRANGE
            var calculator = new Calculator();

            // ACT            

            // ASSERT
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
        }

        [Fact]
        public void IsTypeTest()
        {
            // ARRANGE
            var calculator = new Calculator();

            // ACT            
            var returnValue = calculator.IsGreaterThanZero(5);

            // ASSERT
            Assert.IsType<bool>(returnValue);
        }
    }
}

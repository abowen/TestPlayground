using TestPlayground.Business;
using TestPlayground.Business.Entities;
using Xunit;

namespace TestPlayground.xUnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddUnitTest()
        {
            // ARRANGE
            var calculator = new Calculator();

            // ACT
            var result = calculator.Add(3, 4);

            // ASSERT
            Assert.Equal(7, result);
        }
    }
}

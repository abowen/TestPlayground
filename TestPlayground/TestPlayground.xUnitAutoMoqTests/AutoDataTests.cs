using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture.Xunit;
using TestPlayground.Business.Entities;
using Xunit.Extensions;

namespace TestPlayground.xUnitAutoMoqTests
{
    [TestClass]
    public class AutoDataTests
    {
        [Theory]
        [AutoData]
        public void AutoDataTest(int value1, int value2)
        {
            // ARRANGE
            var calc = new Calculator();

            // ACT
            var result = calc.Add(value1, value2);

            // ASSERT
            Assert.AreEqual(value1 + value2, result);
        }

        [Theory]
        [InlineAutoData(42)]
        [InlineAutoData]
        public void InlineAutoDataTest(int value1, int value2)
        {
            // ARRANGE
            var calc = new Calculator();

            // ACT
            var result = calc.Add(value1, value2);

            // ASSERT
            Assert.AreEqual(value1 + value2, result);
        }
    }
}

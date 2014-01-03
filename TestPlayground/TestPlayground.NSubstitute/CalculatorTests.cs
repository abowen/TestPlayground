using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TestPlayground.Business;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.NSubstituteTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddUnitTest()
        {
            // ARRANGE
            var calculator = Substitute.For<ICalculator>();
            calculator.Add(1, 2).Returns(3);

            // ACT
            var result = calculator.Add(1, 2);

            // ASSERT
            Assert.AreEqual(3, result);
        }
    }
}

using System;
using TestPlayground.Business.Entities;
using Xunit;

namespace TestPlayground.xUnitTests
{
    public class TraitTests
    {
        [Fact]
        [Trait("Category", "TraitExample")]
        public void TraitExampleOneTest()
        {
            // ARRANGE
            var calculator = new Calculator();

            // ACT
            var result = calculator.Add(3, 4);

            // ASSERT
            Assert.Equal(7, result);
        }

        [Fact]
        [Trait("Category", "TraitExample")]
        public void TraitExampleTwoTest()
        {
            // ARRANGE
            var calculator = new Calculator();

            // ACT            

            // ASSERT
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
        }

        [Fact]
        [Category("CustomTraitAttribute")]
        [SmokeTest]
        public void CustomTraitAttributeTest()
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

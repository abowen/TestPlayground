﻿using TestPlayground.Business.Entities;
using Xunit;
using Xunit.Extensions;

namespace TestPlayground.xUnitTests
{
    public class DataDrivenTests
    {
        [Theory]
        [InlineData(int.MinValue,false)]
        [InlineData(-1, false)]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(int.MaxValue, true)]
        public void InlineTest(int value, bool expectedResult)
        {
            // ARRANGE
            var calculator = new Calculator();

            // ACT
            var result = calculator.IsGreaterThanZero(value);

            // ASSERT
            Assert.Equal(expectedResult, result);
        }
    }
}
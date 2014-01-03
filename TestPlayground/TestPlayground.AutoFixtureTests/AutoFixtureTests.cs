using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using TestPlayground.Business.Entities;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.AutoFixtureTests
{
    [TestClass]
    public class AutoFixtureTests
    {
        [TestMethod]
        public void FixtureCreatePrimitiveTest()
        {
            // ARRANGE
            var fixture = new Fixture();
            var expectedNumber = fixture.Create<int>();
            var systemUnderTest = new Calculator();

            // ACT
            var result = systemUnderTest.Add(expectedNumber, expectedNumber);

            // ASSERT
            Assert.AreEqual(expectedNumber*2, result);
        }

        [TestMethod]
        public void FixtureCreateComplexTest()
        {
            // ARRANGE
            var fixture = new Fixture();
            var systemUnderTest = fixture.Create<Person>();

            // ACT
            

            // ASSERT
            Assert.IsFalse(string.IsNullOrWhiteSpace(systemUnderTest.FirstName));
            Assert.IsFalse(string.IsNullOrWhiteSpace(systemUnderTest.LastName));            
        }

        [TestMethod]
        public void FixtureRegisterInterfaceTest()
        {
            // ARRANGE
            var fixture = new Fixture();
            fixture.Register<IRepository>(() => new FakeRepository());
            var systemUnderTest = fixture.Create<EmployeeReporting>();

            // ACT
            var result = systemUnderTest.TotalEmployees();

            // ASSERT
            Assert.IsTrue(result > 0);
        }                
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using TestPlayground.Business.Entities;
using TestPlayground.Business.Interfaces;
using TestPlayground.Business.Services;

namespace TestPlayground.AutoFixtureTests
{
    [TestClass]
    public class AutoFixtureTests
    {
        [TestMethod]
        public void Fixture_Create_Primitive_Property_Test()
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
        public void Fixture_Create_Complex_Class_Test()
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
        public void Fixture_Register_Interface_Using_Custom_Dependency_Test()
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

        [TestMethod]
        public void Fixture_Register_Interface_Using_Fixture_Dependency_Test()
        {
            // ARRANGE
            var fixture = new Fixture();
            fixture.Register<IRepository>(() => new FixtureRepository());
            var systemUnderTest = fixture.Create<EmployeeReporting>();

            // ACT
            var result = systemUnderTest.TotalEmployees();

            // ASSERT
            Assert.IsTrue(result > 0);
        }            
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestPlayground.Business.Entities;
using TestPlayground.Business.Services;
using TestPlayground.MoqTests.Mocks;

namespace TestPlayground.MoqTests
{
    [TestClass]
    public class MoqTests
    {
        [TestMethod]
        public void RepositoryWasCalledTest()
        {
            // ARRANGE
            var repository = new FakeRepository();
            var logger = new FakeLogger();
            var sut = new EmployeeReporting(repository, logger);

            // ACT
            var person = new Employee();
            sut.SaveEmployee(person);

            // ASSERT
            Assert.IsTrue(repository.CreatePersonCalled);
        }

        [TestMethod]
        public void LoggerWasCalledTest()
        {
            // ARRANGE
            var repository = new FakeRepository();
            var logger = new FakeLogger();
            var employeeRepository = new EmployeeReporting(repository, logger);

            // ACT
            employeeRepository.SaveEmployee(null);

            // ASSERT
            Assert.IsTrue(logger.LogErrorCalled);
        }
    }
}

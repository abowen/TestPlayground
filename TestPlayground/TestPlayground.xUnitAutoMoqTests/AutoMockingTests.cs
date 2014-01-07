using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit;
using TestPlayground.Business.Interfaces;
using TestPlayground.Business.Services;
using TestPlayground.xUnitAutoMoqTests.Attributes;
using Xunit;
using Xunit.Extensions;

namespace TestPlayground.xUnitAutoMoqTests
{
    public class AutoMockingTests
    {
        [Fact]
        public void WithoutAutoMocking()
        {
            // ARRANGE
            var mockRepository = new Mock<IRepository>();
            var mockFilter = new Mock<IPersonFilter>();
            var sut = new EmployeeReporting(mockRepository.Object, mockFilter.Object);

            // ACT
            var employees = sut.TotalEmployees();

            // ASSERT
            mockRepository.Verify(x => x.GetPeople(), Times.Once());
        }

        [Fact]
        public void WithAutoMocking()
        {
            // ARRANGE
            var fixture = new Fixture().Customize(new AutoMoqCustomization());            
            var mockRepository = fixture.Freeze<Mock<IRepository>>();
            var sut = fixture.Create<EmployeeReporting>();    

            // ACT
            var employees = sut.TotalEmployees();

            // ASSERT
            mockRepository.Verify(x => x.GetPeople(), Times.Once());
        }

        [Theory]
        [AutoFixtureMoqAutoData]
        public void WithAutoMockingAttribute([Frozen] Mock<IRepository> mockRepository, [Frozen] Mock<IPersonFilter> personFilter, EmployeeReporting sut)
        {
            // ARRANGE            

            // ACT
            var employees = sut.TotalEmployees();

            // ASSERT
            mockRepository.Verify(x => x.GetPeople(), Times.Once());
        }
    }
}

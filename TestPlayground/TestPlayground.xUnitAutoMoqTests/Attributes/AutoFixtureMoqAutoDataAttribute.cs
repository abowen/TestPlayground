using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit;

namespace TestPlayground.xUnitAutoMoqTests.Attributes
{
    public class AutoFixtureMoqAutoDataAttribute : AutoDataAttribute
    {
        public AutoFixtureMoqAutoDataAttribute() : base(new Fixture().Customize(new AutoMoqCustomization()))
        {
            
        }
    }
}

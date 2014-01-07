using Xunit;

namespace TestPlayground.xUnitTests.Attributes
{
    public class SmokeTestAttribute : TraitAttribute
    {
        public SmokeTestAttribute() : base("Category", "SmokeTest")
        {
        }
    }
}

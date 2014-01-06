using Xunit;

namespace TestPlayground.xUnitTests
{
    public class SmokeTestAttribute : TraitAttribute
    {
        public SmokeTestAttribute()
            : base("Category", "SmokeTest")
        {
        }
    }
}

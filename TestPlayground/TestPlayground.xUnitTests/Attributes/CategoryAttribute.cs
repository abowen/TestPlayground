using Xunit;

namespace TestPlayground.xUnitTests
{
    public class CategoryAttribute : TraitAttribute
    {
        public CategoryAttribute(string value) : base("Category", value)
        {
        }
    }
}

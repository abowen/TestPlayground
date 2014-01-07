using Xunit;

namespace TestPlayground.xUnitTests.Attributes
{
    public class CategoryAttribute : TraitAttribute
    {
        public CategoryAttribute(string value) : base("Category", value)
        {
        }
    }
}

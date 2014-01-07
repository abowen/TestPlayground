using TestPlayground.Business.Entities;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.AutoFixtureTests.Helpers
{
    public class FakePersonFilter : IPersonFilter
    {        
        public bool Filter(Person person)
        {
            return person != null;
        }
    }
}

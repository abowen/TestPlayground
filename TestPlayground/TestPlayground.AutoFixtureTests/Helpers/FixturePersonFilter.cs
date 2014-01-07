using System.Collections.Generic;
using Ploeh.AutoFixture;
using TestPlayground.Business.Entities;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.AutoFixtureTests.Helpers
{
    public class FixturePersonFilter : IPersonFilter
    {
        public bool Filter(Person person)
        {
            var fixture = new Fixture();
            return fixture.Create<bool>();
        }
    }
}

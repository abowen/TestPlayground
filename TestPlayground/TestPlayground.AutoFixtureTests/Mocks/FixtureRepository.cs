using System.Collections.Generic;
using Ploeh.AutoFixture;
using TestPlayground.Business.Entities;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.AutoFixtureTests.Mocks
{
    public class FixtureRepository : IRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            var fixture = new Fixture();
            var people = fixture.CreateMany<Person>();
            return people;
        }

        public void CreatePerson(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}

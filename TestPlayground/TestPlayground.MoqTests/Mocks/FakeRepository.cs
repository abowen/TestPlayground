using System;
using System.Collections.Generic;
using TestPlayground.Business.Entities;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.MoqTests.Mocks
{
    public class FakeRepository : IRepository
    {
        public IEnumerable<Person> GetPeople()
        {            
            var person = new Person
            {
                DateOfBirth = new DateTime(1955, 5, 5),
                FirstName = "Andrew",
                LastName = "Test"
            };
            return new List<Person> { person };
        }

        internal bool CreatePersonCalled = false;

        public void CreatePerson(Person person)
        {
            CreatePersonCalled = true;
        }
    }
}

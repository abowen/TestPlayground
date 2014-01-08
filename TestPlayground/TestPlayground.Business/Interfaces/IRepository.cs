using System.Collections.Generic;
using TestPlayground.Business.Entities;

namespace TestPlayground.Business.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Person> GetPeople();

        void CreatePerson(Person person);
    }
}

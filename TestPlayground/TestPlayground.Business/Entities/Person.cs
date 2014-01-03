using System;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.Business.Entities
{
    public class Person :IPerson
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public DateTime DateOfBirth { get;  set; }
    }
}

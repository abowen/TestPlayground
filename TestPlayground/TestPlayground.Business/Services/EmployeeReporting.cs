using System;
using System.Linq;
using TestPlayground.Business.Entities;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.Business.Services
{
    public class EmployeeReporting
    {
        private readonly IRepository _repository;
        private readonly ILogger _logger;

        public EmployeeReporting(IRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        private static bool DefaultFilter(Person person)
        {
            return true;
        }

        public int TotalEmployees(Func<Person, bool> userFilter = null)
        {
            var personFilter = userFilter ?? DefaultFilter;
            return _repository.GetPeople().Where(personFilter).Count();
        }

        public void SaveEmployee(Employee employee)
        {
            if (employee == null)
            {
                _logger.LogError("Missing Value");
            }
            else
            {
                _repository.CreatePerson(employee);
            }
        }
    }
}

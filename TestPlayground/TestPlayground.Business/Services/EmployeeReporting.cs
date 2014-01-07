using System.Linq;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.Business.Services
{
    public class EmployeeReporting
    {
        private readonly IRepository _repository;
        private readonly IPersonFilter _personFilter;

        public EmployeeReporting(IRepository repository, IPersonFilter personFilter)
        {
            _repository = repository;
            _personFilter = personFilter;
        }

        public int TotalEmployees()
        {
            return _repository.GetPeople().Count(_personFilter.Filter);
        }
    }
}

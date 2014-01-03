using System.Linq;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.Business.Entities
{
    public class EmployeeReporting
    {
        private readonly IRepository _repository;

        public EmployeeReporting(IRepository repository)
        {
            _repository = repository;
        }
        public int TotalEmployees()
        {
            return _repository.GetPeople().Count();
        }
    }
}

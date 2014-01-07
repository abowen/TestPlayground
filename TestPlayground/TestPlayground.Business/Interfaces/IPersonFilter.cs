using TestPlayground.Business.Entities;

namespace TestPlayground.Business.Interfaces
{
    public interface IPersonFilter
    {
        bool Filter(Person person);
    }
}

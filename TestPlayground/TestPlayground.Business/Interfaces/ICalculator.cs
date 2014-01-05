namespace TestPlayground.Business.Interfaces
{
    public interface ICalculator
    {
        int Add(int a, int b);

        int Divide(int a, int b);

        int Multiple(int a, int b);

        int Subtract(int a, int b);

        bool IsGreaterThanZero(int a);
    }
}

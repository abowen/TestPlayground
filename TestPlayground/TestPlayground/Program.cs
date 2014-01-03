using System;
using TestPlayground.Business;
using TestPlayground.Business.Entities;

namespace TestPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Integer: ");
            var valueA = Console.ReadLine();
            Console.Write("Second Integer: ");
            var valueB = Console.ReadLine();
            var calculator = new Calculator();
            var result = calculator.Add(Convert.ToInt32(valueA), Convert.ToInt32(valueB));
            Console.WriteLine("Result: {0}", result);
            Console.ReadLine();
        }
    }
}

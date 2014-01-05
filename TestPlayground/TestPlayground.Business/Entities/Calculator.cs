using System;
using System.Diagnostics.Contracts;
using TestPlayground.Business.Interfaces;

namespace TestPlayground.Business.Entities
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            Contract.Assert(b != 0);
            return a / b;
        }

        public int Multiple(int a, int b)
        {            
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            if (b == 100)
            {
                throw new Exception("Deliberate Bug");
            }
            return a - b;
        }

        public bool IsGreaterThanZero(int a)
        {
            return a > 0;
        }
    }
}

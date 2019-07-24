using System;

namespace xUnitDemo
{
    public class Calculator: ICalculator
    {
        public int Add(int a, int b)
            => a + b;

        public int Multiply(int a, int b)
            => a * b;
        public int Subs(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}

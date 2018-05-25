using System;

namespace Proxy
{
    internal class Math : IMath
    {
        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
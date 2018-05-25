using System;

namespace Proxy
{
    public class MathProxy : IMath
    {
        private readonly Math math;

        public MathProxy()
        {
            math = new Math();
        }

        public double Divide(double a, double b)
        {
            if (System.Math.Abs(b) < Double.Epsilon)
            {
                throw new InvalidOperationException("cannot divide by zero");
            }
            return Divide(a, b);
        }

        public double Multiply(double a, double b)
        {
            return math.Multiply(a, b);
        }
    }
}
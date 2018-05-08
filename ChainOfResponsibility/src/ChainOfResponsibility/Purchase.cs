using System;

namespace ChainOfResponsibility
{
    public struct Purchase 
    {
        public Purchase(double amount, int number, string description)
        {
            Amount = amount;
            Number = number;
            Description = description;
        }

        public double Amount { get; }
        public int Number { get; }
        public string Description { get; }

        public static explicit operator Purchase((double, int , string) tuple)
        {
            return new Purchase(tuple.Item1, tuple.Item2, tuple.Item3);
        }
    }
}
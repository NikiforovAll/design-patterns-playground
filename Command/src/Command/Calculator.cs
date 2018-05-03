using System;

namespace Command
{
    public class Calculator
    {
        private int _curr = 0;

        public int CurrentResult { get => _curr; set => _curr = value; }

        public int Operate(char @operator, int operand)
        {
            // possibility to use interpreter pattern
            switch (@operator)
            {
                case '+': CurrentResult += operand; break;
                case '-': CurrentResult -= operand; break;
                case '*': CurrentResult *= operand; break;
                case '/': CurrentResult /= operand; break;
            }

            return CurrentResult;
        }
    }
}

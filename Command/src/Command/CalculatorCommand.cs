using System;

namespace Command
{
    public class CalculatorCommand : Command
    {
        private readonly Calculator calculator;
        private readonly char @operator;
        private readonly int operand;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.calculator = calculator;
            this.@operator = @operator;
            this.operand = operand;
        }

        public override double Execute()
        {
            return calculator.Operate(@operator, operand);
        }

        public override double UnExecute()
        {
            return calculator.Operate(GetUndoOperator(@operator), operand);
        }

        private char GetUndoOperator(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException(nameof(@operator) + "is not found");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Command
{
    public class CalculatorClient
    {
        private Calculator calculator = new Calculator();
        private Stack<Command> _commands = new Stack<Command>();

        public int Result { get => calculator.CurrentResult; }

        public double Compute(char @operator, int operand)
        {
            var command = new CalculatorCommand(calculator, @operator, operand);
            _commands.Push(command);
            return command.Execute();
        }

        public double Undo()
        {
            return _commands.Pop().UnExecute();
        }
    }
}
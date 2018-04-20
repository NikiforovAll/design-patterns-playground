using System;

namespace Interpreter
{
    public class TerminalExpression: AbstractInterpreter
    {
        public int Value { get; set; } = 1;
        public TerminalExpression(int value)
        {
            Value = value;
        }

        public override int Interpret(Context context)
        {
            //although probably interpreter should not contain actual state to interpret
            return context.MULTIPLIER * Value;
        }
    }
}

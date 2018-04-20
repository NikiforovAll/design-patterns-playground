using System;

namespace Interpreter
{
    public class NonTerminalExpression : AbstractInterpreter
    {
        public Func<int, int, int> BinaryOperation { get; set; } = (a, b) => 0;
        public override int Interpret(Context context)
        {
            if (context.TerminalExpressionArgs.Length < 2)
            {
                throw new ArgumentException("should be at least 2 terminal params");
            }
            return BinaryOperation?.Invoke(context.TerminalExpressionArgs[0].Interpret(context), context.TerminalExpressionArgs[1].Interpret(context)) ?? 0;
        }
    }
}

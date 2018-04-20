using System;
using Xunit;
using Interpreter;

namespace InterpreterTest
{
    public class InterpreterTest
    {
        [Fact]
        public void Main_Test()
        {
            var context = new Context();
            context.TerminalExpressionArgs = new TerminalExpression[] {
                new TerminalExpression(1),
                new TerminalExpression(2)
            };


            AbstractInterpreter[] interpreters = new AbstractInterpreter[]{
                new TerminalExpression(3),
                new NonTerminalExpression(){BinaryOperation = (a, b)=>a*b}
            };

            Assert.Collection(interpreters,
                (interpreter) =>
                {
                    Assert.Equal(6, interpreter.Interpret(context));
                },
                (interpreter) =>
                {
                    Assert.Equal(8, interpreter.Interpret(context));
                });
        }
    }
}

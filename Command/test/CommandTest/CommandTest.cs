using System;
using Xunit;
using Command;
using System.Collections.Generic;

namespace CommandTest
{
    public class UnitTest1
    {
        [Fact]
        public void CommandTest_main()
        {
            var operations = new List<(char @operator, int operand)>{
                ('+', 10),
                ('-', 5),
                ('*', 3)
            };
            CalculatorClient client = new CalculatorClient();
            foreach (var operation in operations)
            {
                client.Compute(operation.@operator, operation.operand);
            }

            Assert.Equal(15, client.Result);
            client.Undo();
            Assert.Equal(5, client.Result);
        }
    }
}

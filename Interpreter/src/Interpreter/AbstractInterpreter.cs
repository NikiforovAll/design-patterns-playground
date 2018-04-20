using System;

namespace Interpreter
{
    public abstract class AbstractInterpreter
    {
        public abstract int Interpret(Context context);
    }
}

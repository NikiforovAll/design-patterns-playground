using System;

namespace Command
{
    public abstract class Command
    {
        public abstract double Execute();
        public abstract double UnExecute();
    }
}

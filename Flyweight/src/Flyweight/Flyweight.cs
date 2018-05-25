using System;

namespace Flyweight
{
    public enum Priority {Low = 3, Medium = 5, High = 10}
    public abstract class Flyweight
    {
        public abstract int Operation();
    }
}

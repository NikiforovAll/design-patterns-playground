using System;

namespace Observer
{
    public abstract class Observer
    {
        public abstract void Update(Subject state);
    }
}

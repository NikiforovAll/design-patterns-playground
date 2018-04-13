using System;

namespace Iterator
{
    public abstract class Iterator<T>
    {
        public abstract T First();
        public abstract T Next();

        public abstract bool IsDone();

        public abstract T CurrentItem();

    }
}

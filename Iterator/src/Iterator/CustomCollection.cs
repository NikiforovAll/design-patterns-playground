using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class CustomCollection<T> : ICustomCollection<T>, IEnumerable<T>
    {
        private List<T> _values = new List<T>();

        public T this[int index]
        {
            get => _values[index];set => _values[index] = value;
        }

        public int Count { get => _values.Count; }

        public Iterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public void Add(T item)
        {
            _values.Add(item);
        }
        //it is better approach to use IEnumerable interfaces to implement Iterator pattern for language support and compatability, although I tryied to stick to canonized version
        public IEnumerator<T> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _values.GetEnumerator();
        }
    }
}
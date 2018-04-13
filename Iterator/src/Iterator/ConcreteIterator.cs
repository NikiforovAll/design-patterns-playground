namespace Iterator
{
    public class ConcreteIterator<T> : Iterator.Iterator<T>
    {

        public ConcreteIterator(CustomCollection<T> collection)
        {
            _collection = collection;
        }

        public int Step {get; set;} = 2;
        private CustomCollection<T> _collection;

        private int _currentIndex;

        public override T CurrentItem()
        {
            return _collection[_currentIndex];
        }

        public override T First()
        {
            return _collection[0];

        }

        public override bool IsDone()
        {
            return _currentIndex > _collection.Count - 1;
        }

        public override T Next()
        {
            T result = default(T);
            if (!IsDone())
            {
                result = _collection[_currentIndex];
                _currentIndex += Step;
            }
            return result;
        }
    }
}
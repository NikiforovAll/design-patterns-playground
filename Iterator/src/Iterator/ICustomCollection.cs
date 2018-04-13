namespace Iterator
{
    public interface ICustomCollection<T>
    {
        Iterator.Iterator<T> CreateIterator();

        T this[int index]
        {
            get; set;
        }
    }
}
namespace PatternsConsole.Behavioral.Iterator
{
    public abstract class Aggregate<T>
    {
        public abstract Iterator<T> CreateIterator();
        public T[] Data { get; set; }
    }
}
namespace PatternsConsole.Behavioral.Iterator
{
    public class ConcreteIterator<T> : Iterator<T>
    {
        private readonly Aggregate<T> _aggregate;
        private int _index;

        public ConcreteIterator(Aggregate<T> aggregate)
        {
            _aggregate = aggregate;
        }

        public void First()
        {
            _index = 0;
        }

        public void Next()
        {
            _index++;
        }

        public bool IsDone()
        {
            return _index > _aggregate.Data.Length-1;
        }

        public T CurrentItem()
        {
            return _aggregate.Data[_index];
        }
    }
}
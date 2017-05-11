namespace PatternsConsole.Behavioral.Iterator
{
    public class IntAggregate : Aggregate<int>
    {
        public override Iterator<int> CreateIterator()
        {
            return new ConcreteIterator<int>(this);
        }
    }
}
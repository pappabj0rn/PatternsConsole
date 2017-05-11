namespace PatternsConsole.Behavioral.Iterator
{
    public interface Iterator<T>
    {
        void First();
        void Next();
        bool IsDone();
        T CurrentItem();
    }
}
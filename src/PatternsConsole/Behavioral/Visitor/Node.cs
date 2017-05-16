namespace PatternsConsole.Behavioral.Visitor
{
    public abstract class Node
    {
        public abstract void Accept(Visitor v);
    }
}
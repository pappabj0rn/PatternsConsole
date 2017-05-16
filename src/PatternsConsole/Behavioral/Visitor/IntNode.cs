namespace PatternsConsole.Behavioral.Visitor
{
    public class IntNode : Node
    {
        public int Value { get; set; }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
namespace PatternsConsole.Behavioral.Visitor
{
    public class StringNode : Node
    {
        public string Value { get; set; }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
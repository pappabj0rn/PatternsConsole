namespace PatternsConsole.Behavioral.Interpeter
{
    public class VariableExpression : BooleanExpression
    {
        public string Name { get; }

        public VariableExpression(string name)
        {
            Name = name;
        }

        public override bool Evaluate(Context c)
        {
            return c.Lookup(Name);
        }
    }
}
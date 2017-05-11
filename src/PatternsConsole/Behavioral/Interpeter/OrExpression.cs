namespace PatternsConsole.Behavioral.Interpeter
{
    public class OrExpression : BooleanExpression
    {
        public BooleanExpression A { get; }
        public BooleanExpression B { get; }

        public OrExpression(BooleanExpression a, BooleanExpression b)
        {
            A = a;
            B = b;
        }

        public override bool Evaluate(Context c)
        {
            return A.Evaluate(c) || B.Evaluate(c);
        }
    }
}
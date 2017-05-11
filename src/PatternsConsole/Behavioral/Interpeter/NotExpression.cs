namespace PatternsConsole.Behavioral.Interpeter
{
    public class NotExpression : BooleanExpression
    {
        private readonly BooleanExpression _a;

        public NotExpression(BooleanExpression a)
        {
            _a = a;
        }
        public override bool Evaluate(Context c)
        {
            return !_a.Evaluate(c);
        }
    }
}
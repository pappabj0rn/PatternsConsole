namespace PatternsConsole.Behavioral.Interpeter
{
    public class ConstantExpression : BooleanExpression
    {
        private readonly bool _constant;

        public ConstantExpression(bool constant)
        {
            _constant = constant;
        }

        public override bool Evaluate(Context c)
        {
            return _constant;
        }
    }
}
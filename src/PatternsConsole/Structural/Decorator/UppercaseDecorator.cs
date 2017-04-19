namespace PatternsConsole.Structural.Decorator
{
    public class UppercaseDecorator : Decorator
    {
        public UppercaseDecorator(StringComponent decoratedComponent) : base(decoratedComponent)
        {
        }

        public override string GetString() => DecoratedComponent.GetString().ToUpper();
    }
}
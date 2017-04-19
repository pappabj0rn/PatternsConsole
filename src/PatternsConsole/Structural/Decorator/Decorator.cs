namespace PatternsConsole.Structural.Decorator
{
    public abstract class Decorator : StringComponent
    {
        protected readonly StringComponent DecoratedComponent;

        protected Decorator(StringComponent decoratedComponent)
        {
            DecoratedComponent = decoratedComponent;
        }
    }
}
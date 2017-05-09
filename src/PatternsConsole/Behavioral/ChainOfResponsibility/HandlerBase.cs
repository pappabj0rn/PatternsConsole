namespace PatternsConsole.Behavioral.ChainOfResponsibility
{
    public abstract class HandlerBase
    {
        private readonly HandlerBase _successor;

        protected HandlerBase(HandlerBase successor)
        {
            _successor = successor;
        }

        public virtual void HandleRequest(Topic topic)
        {
            _successor?.HandleRequest(topic);
        }
    }
}
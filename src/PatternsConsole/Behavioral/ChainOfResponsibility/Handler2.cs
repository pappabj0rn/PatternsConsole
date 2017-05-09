using System;

namespace PatternsConsole.Behavioral.ChainOfResponsibility
{
    public class Handler2 : HandlerBase
    {
        public Handler2(HandlerBase successor) : base(successor)
        {
        }

        public override void HandleRequest(Topic topic)
        {
            if (topic == Topic.Topic2)
                Console.WriteLine("Handler2: Info about topic2.");
            else
            {
                Console.Write("Handler2: No info.\n   ");
                base.HandleRequest(topic);
            }
        }
    }
}
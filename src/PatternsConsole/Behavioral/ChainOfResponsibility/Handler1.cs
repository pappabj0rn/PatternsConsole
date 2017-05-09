using System;

namespace PatternsConsole.Behavioral.ChainOfResponsibility
{
    public class Handler1 : HandlerBase
    {
        public Handler1(HandlerBase successor) : base(successor)
        {
        }

        public override void HandleRequest(Topic topic)
        {
            if (topic == Topic.Topic1)
                Console.WriteLine("Handler1: Info about topic1.");
            else
            {
                Console.Write("Handler1: No info.\n   ");
                base.HandleRequest(topic);
            }
        }
    }
}
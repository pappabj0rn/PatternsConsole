
using System;

namespace PatternsConsole.Behavioral.ChainOfResponsibility
{
    public class ChainOfResponsibilityRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var handler1 = new Handler1(null);
            var handler2 = new Handler2(handler1);

            Console.Write("Asking handler2 to handle topic2.\n   ");
            handler2.HandleRequest(Topic.Topic2);

            Console.Write("\nAsking handler2 to handle topic1.\n   ");
            handler2.HandleRequest(Topic.Topic1);

            Console.Write("\nAsking handler2 to handle topic3.\n   ");
            handler2.HandleRequest(Topic.Topic3);
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "Chain Of Responsibility";

        public override string Description =>
                BreakLine("Avoid coupling the sender of a request to its receiver by " +
                          "giving more than one object a chanse to handle the request. " +
                          "Chain the receiving objects and pass tha request along the " +
                          "chain until an object handles it.");

        public override string PageRef => "223";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("more than one object may handle a request, and the handler isn't known a priori. The handler should be ascertained automatically."),
            BreakLine("you want to issue a request to one of several objects without specifying the receiver explicitly."),
            BreakLine("the set of objects that can handle a request should be specified dynamically.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "Reduced coupling.",
            "Added flexibility in assigning responsibilities to objects.",
            "Receipt isn't guaranteed."
        };
    }
}

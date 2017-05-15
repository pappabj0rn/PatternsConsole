using System;

namespace PatternsConsole.Behavioral.Observer
{
    public class ObserverRunner : PatternRunnerBase
    {
        public override void Run()
        {
            Console.WriteLine("Creating IntSubject.");
            var subject = new IntSubject();

            Console.WriteLine("Creating five IntObservers, and updating subject after each.\n");
            for (var i = 0; i < 5; i++)
            {
                subject.Attach(new IntObserver());
                Console.WriteLine($"Updating subject state to {i}.");
                subject.SetState(i);
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine("\nUpdating subject state to 1337.");
            subject.SetState(1337);
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "Observer";
        public override string AlsoKnownAs => "Dependetns, Publish-Subscribe";
        public override string Description => BreakLine("Define a ont-to-many dependency between objects so that " +
                                                        "when one object changes state, all its dependents are " +
                                                        "notified and updated automatically.");
        public override string PageRef => "293";

        public override string ApplicabilityLeadin => "Use the Observer patterin in any of the following situations:";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("Ehen an abstraction has two aspects, one dependent on the other. " +
                      "Encapsulating these aspects in separate objects lets you vary and " +
                      "reuse them independently."),
            BreakLine("When a change to one object requires changing others, and you " +
                      "don't know how many objects need to be changed."),
            BreakLine("Ehen an object should be able to notify other objects without " +
                      "making assumptions about who these objects are. In other words, " +
                      "you donät want these objects tightly coupled.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "Abstract coupling between Subject and Observer.",
            "Support for broadcast communication.",
            "Unexpected updates."
        };
    }
}

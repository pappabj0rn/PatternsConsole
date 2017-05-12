using System;
using System.Linq;

namespace PatternsConsole.Behavioral.Memento
{
    public class MementoRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var memstr = new MementoSpaceString();
            const string testString = "A test string with spaces";

            memstr.Value = testString;

            Console.WriteLine($"Test string: {testString}");
            PrintMementoSpaceStringData(memstr);

            Console.WriteLine("Creating restore point.");
            var state = memstr.CreateMemento();

            Console.WriteLine("Removing first space");
            var mod = memstr.CreateMemento();
            mod.SpacePositions.RemoveAt(0);
            memstr.SetMemento(mod);

            PrintMementoSpaceStringData(memstr);

            Console.WriteLine("Restoring state.");

            memstr.SetMemento(state);

            PrintMementoSpaceStringData(memstr);
        }

        private static void PrintMementoSpaceStringData(MementoSpaceString memstr)
        {
            Console.WriteLine($"MementoSpaceString value: {memstr.Value}");
            Console.WriteLine($"MementoSpaceString space positions: {memstr.CreateMemento().SpacePositions.Aggregate("", (cur, next) => cur + ", " +next).Trim(',', ' ')}");
            Console.WriteLine($"MementoSpaceString ToString: {memstr}");
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "Memento";
        public override string AlsoKnownAs => "Token";
        public override string Description => BreakLine("Without violating encapsulation, capture " +
                                                        "and externalize an object's internal " +
                                                        "state so that the object can be restored " +
                                                        "to this state later.");
        public override string PageRef => "283";

        public override string ApplicabilityLeadin => "Use the Memento pattern when";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("a snapshot of (some portion of) an object's state must be saved so that it can be restored to that state later, and"),
            BreakLine("a direct interface to obtaining the state would expose implementation details and break the objectäs encapsulation.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "Perserving encapsulation boundaries.",
            "It simplifies Originator.",
            "Using mementos might be expensive.",
            "Defining narrow and wide interfaces.",
            "Hidden costs in caring for mementos."
        };
    }
}

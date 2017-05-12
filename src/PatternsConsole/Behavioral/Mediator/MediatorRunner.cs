using System;

namespace PatternsConsole.Behavioral.Mediator
{
    public class MediatorRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var mediator = new Mediator();
            WriteMediatorState(mediator);

            Console.WriteLine("Setting name to Trogdor.");
            mediator.SetName("Trogdor");
            WriteMediatorState(mediator);

            Console.WriteLine("Flipping the flop.");
            mediator.SwitchFlipFlop();
            WriteMediatorState(mediator);
        }

        private static void WriteMediatorState(Mediator mediator)
        {
            Console.WriteLine("Mediator state:\n" + mediator.State);
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "Mediator";
        public override string Description => BreakLine("Define an object that encapsulates how a set of objects " +
                                                        "interact. Mediator promotes loos coupling by keeping " +
                                                        "objects from referring to each other explicitly, and it " +
                                                        "lets you vary their interacton independently.");
        public override string PageRef => "273";

        public override string ApplicabilityLeadin => "Use the Mediator pattern when";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("a set og objects communicate in well-defined but complex ways. " +
                      "The resulting interdependencies are unstructured and difficult " +
                      "to understand."),
            BreakLine("reusing an object is difficult because it refers to and " +
                      "communicates with many other objects."),
            BreakLine("a behaviour that's distributed between several classes should " +
                      "be customizable without a lot of subclassing."),
        };

        protected override string[] ConsequencesLines => new[]
        {
            "It limits subclassing.",
            "It decouples colleagues.",
            "It simplifies object protocols.",
            "It abstracts how objects cooperate.",
            "It centralizes control."
        };
    }
}

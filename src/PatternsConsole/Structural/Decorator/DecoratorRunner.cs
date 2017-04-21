using System;

namespace PatternsConsole.Structural.Decorator
{
    public class DecoratorRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var tm = new TextMessage {Text = "Hello World"};
            var decorator = new UppercaseDecorator(tm);

            Console.WriteLine($"Text: {tm.GetString()}");
            Console.WriteLine($"Decorated with UppercaseDecorator: {decorator.GetString()}");
        }

        public override PatternCategory Category => PatternCategory.Structural;
        public override string Name => "Decorator";
        public override string Description => BreakLine("Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.");
        public override string AlsoKnownAs => "Wrapper";
        public override string PageRef => "175";

        public override string ApplicabilityLeadin => "Use Decorator";
        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("to add responsibilities to individual objects dynamically and transparently, that is, without affecting other objects."),
            BreakLine("for responsibilities that can be withdrawn."),
            BreakLine("when extensions by subclassing is impractical. Sometimes a large number of indipendent extensions are possible and would produce an explosion of subclasses to support every combination. Or a class definition may be hidden or otherwise unavailable for subclassing.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "More flexible that static inheritance.",
            "Avoids feature-laden classes high up in the hierarchy.",
            "A decorator and its components aren't identical.",
            "Lots of little objects."
        };
   }
}
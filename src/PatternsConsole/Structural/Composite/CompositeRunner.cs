namespace PatternsConsole.Structural.Composite
{
    public class CompositeRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var comp = new CompositeOutput();
            comp.Components.Add(new StringOutput("Hello World\n"));
            comp.Components.Add(new DividerOutpout("=",11));
            comp.Components.Add(new StringOutput("\npew pew pew"));

            comp.Print();
        }

        public override PatternCategory Category => PatternCategory.Structural;
        public override string Name => "Composite";
        public override string PageRef => "163";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("you want to represent part-whole hierarchies of objects."),
            BreakLine("you want clients to be able to ignore the difference between composition of objects and individual objects. Clients will treat all objects in the composite structure uniformly.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "Defines class hierarchies conststing of primitive objects and composit objects",
            "Makes the client simple.",
            "Makes it easier to add new kinds of components.",
            "Can make your design overly general.",
        };
   }
}
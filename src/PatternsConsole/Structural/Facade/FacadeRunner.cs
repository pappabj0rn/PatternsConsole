namespace PatternsConsole.Structural.Facade
{
    public class FacadeRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var facade = new Facade();
            const int a = 2;
            const int b = 3;
            var sum = facade.CalcSum(a,b);
            var prod = facade.CalcProduct(a,b);

            facade.WriteMessage($"Sum of {a} and {b} =  {sum}");
            facade.WriteMessage($"Product of {a} and {b} =  {prod}");
        }

        public override PatternCategory Category => PatternCategory.Structural;
        public override string Name => "Facade";
        public override string PageRef => "185";

        public override string ApplicabilityLeadin => "Use the Facade oattern when";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("you want to provide a simple interface to a complet subsystem. Subsystems often get more complex as the evolve. Most patterns, when applied, result in more and smaller classes. This makes the subsystem more resusable and easier to customize, but it also ecomes harder to use for clients that don't need to customize it. A facade can provide a simple default view of the subsystem that is good enough for most clients. Only clients needing more customizability will need to look beyond the facade."),
            BreakLine("there are manu dependencies between clients and the implrementation classes of and abstraction. Introduce a facade to decouple the subsystem from clients and other subsystems, thereby promoting subsystem independence and portability."),
            BreakLine("you want to layer your subsystems. Use a facade to define an entry point to each subsystem level. If subsystems are depentent, then you can simplify the dependencies between them by making them communicate with each other solely through theur facades.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            BreakLine("Shields clients from subsystem components."),
            BreakLine("Promotes weak coupling between the subsystem and its clients."),
            BreakLine("Doensn't prevent clients from using subsystems directly if the need to."),
        };
   }
}
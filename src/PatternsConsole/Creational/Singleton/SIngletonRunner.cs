using System;

namespace PatternsConsole.Creational.Singleton
{
    public class SingletonRunner : PatternRunnerBase
    {
        public override void Run()
        {
            Console.WriteLine("Calling SayHello on Singleton.Instance:");
            Singleton.Instance.SayHello();

            Console.WriteLine("Calling SayHello on SubSingleton.Instance:");
            SubSingleton.Instance.SayHello();

            Console.WriteLine("Calling SetInstance on SubSingleton.");
            SubSingleton.SetInstance();

            Console.WriteLine("Calling SayHello on Singleton.Instance:");
            Singleton.Instance.SayHello();

            Console.WriteLine("Calling SayHello on SubSingleton.Instance:");
            SubSingleton.Instance.SayHello();
        }

        public override PatternCategory Category => PatternCategory.Creational;
        public override string Name => "Singleton";
        public override string Description => BreakLine("Ensure a class only has one instance, and provide a global point of access to it.");
        public override string PageRef => "127";
        protected override string[] ConsequencesLines => new[]
        {
            "Constolled access to sole instnace.",
            "Reduced name space.",
            "Permits refinement of operations and representation.",
            "Permits a variable number of instances.",
            "More flexible than class oiperations."
        };
        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("there must be exactly one instance of a class, and if it must be accessible to clients from a well-known access point."),
            BreakLine("when the sole instance should be extensible bu subclassing and clients should be able to use an extended instance without modifying their code.")
        };
    }
}

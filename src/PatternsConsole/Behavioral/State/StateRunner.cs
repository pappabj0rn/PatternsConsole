using System;

namespace PatternsConsole.Behavioral.State
{
    public class StateRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var cc = new ConsoleConnection();
            
            cc.Open();
            cc.WriteLine("Hello from open ConsoleConnection.");

            cc.Close();
            try
            {
                cc.WriteLine("test");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to write line with ConsoleConnection. e: {e.Message}");
            }
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "State";
        public override string AlsoKnownAs => "Objects for States";
        public override string Description => BreakLine("Allow an object to alter its behaviour when its " +
                                                        "internal state changes. The object will appear " +
                                                        "to change its class.");
        public override string PageRef => "305";

        public override string ApplicabilityLeadin => "Use the ConsoleState patterin in either of the following cases:";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("An object's behaviour depends on its state, and it must " +
                      "change its behaviour at run-time depending on that state."),
            BreakLine("Operations have large, multipart conditional statements " +
                      "that depend on the object's state. This state is usually " +
                      "represented by one or more enumerated constants. Often, " +
                      "several operations will contain this same conditional " +
                      "structure. The ConsoleState pattern puts each branch of the " +
                      "conditional in a separate class. This lets you treat the " +
                      "object's state as an object in its own right that can vary " +
                      "independently from other objects.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            BreakLine("It localizes state-specific behaviour and partitions behaviour for different states."),
            "It makes state transitions explicit.",
            "ConsoleState objects can be shared."
        };
    }
}

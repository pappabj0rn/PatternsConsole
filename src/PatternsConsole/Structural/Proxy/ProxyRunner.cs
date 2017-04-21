using System;

namespace PatternsConsole.Structural.Proxy
{
    public class ProxyRunner : PatternRunnerBase
    {
        public override void Run()
        {
            ConsoleString proxy = new ExpensiveConsoleStringProxy();
            Console.WriteLine("Allocating space for expensive string.");
            Console.Write("|");
            for (int i = 0; i < proxy.Length; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|\n ");

            proxy.Draw();
        }

        public override PatternCategory Category => PatternCategory.Structural;
        public override string Name => "Proxy";
        public override string AlsoKnownAs => "Surrogate";
        public override string Description => BreakLine("Provide a surrogate or placeholder for another object to control access to it.");
        public override string PageRef => "207";

        public override string ApplicabilityLeadin => BreakLine("Proxy is applicable whenever there is a need for a more versatile or sophisticated reference to an object than a simple pointer. Here are several common situations in which the Proxy pattern is applicable:", "");

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("A remote proxy provides a local representative for an object in a different address space."),
            BreakLine("A virtual proxy creates expensive objects on demand."),
            BreakLine("A protection proxy controls acces to the original object."),
            BreakLine("A smart reference is a replacement for bara pointers that performs additional actions when an object is accessed.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "A remote proxy can hide the fact that an object resides in a different address space.",
            "A virtual proxy can perform optimizations such as creating an object on demand.",
            "Protection proxies and smart references allow additional housekeeping tasks when an object is accessed.",
            BreakLine("The Proxy pattern can hide copy-on-write, related to creation on demand. If copying an object is expensive, it can be defered until the client needs to modify the object.")
        };
    }
}
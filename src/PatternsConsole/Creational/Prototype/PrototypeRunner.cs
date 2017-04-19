using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternsConsole.Creational.Prototype
{
    public class PrototypeRunner : PatternRunnerBase
    {
        public override void Run()
        {
            Console.WriteLine("Creating prototype and container.");
            var lp = new StringPrototype();
            var prototypes = new List<Prototype>();

            Console.WriteLine("Configuring prototype and creating clones.");
            lp.String = "H";
            prototypes.Add(lp.Clone());
            lp.String = "e";
            prototypes.Add(lp.Clone());
            lp.String = "l";
            prototypes.Add(lp.Clone());
            prototypes.Add(lp.Clone());
            lp.String = "o";
            prototypes.Add(lp.Clone());
            lp.String = " ";
            prototypes.Add(lp.Clone());
            lp.String = "W";
            prototypes.Add(lp.Clone());
            lp.String = "o";
            prototypes.Add(lp.Clone());
            lp.String = "r";
            prototypes.Add(lp.Clone());
            lp.String = "l";
            prototypes.Add(lp.Clone());
            lp.String = "d";
            prototypes.Add(lp.Clone());

            Console.WriteLine("Aggregating prototypes.");

            var aggregate = prototypes.Aggregate("", (c, n) => c + n);
            Console.WriteLine(aggregate);
        }

        public override PatternCategory Category => PatternCategory.Creational;
        public override string Name => "Prototype";
        public override string PageRef => "117";

        protected override string[] ConsequencesLines => new[]
        {
            "Adding and removing products at run-time.",
            "Specifying new objects by varying values.",
            "Specifying new objects by varying structure.",
            "Reduced subclassing.",
            "Configuring an application with classes dynamically.",
        };
        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("when the classes to instantiate are specified at run-time, for example by dynamic loading; or"),
            BreakLine("to avoid buildning a class hierarchy of factories that parallels the class hierarchy of product; or"),
            BreakLine("when instances of a class can have one of only a few different combintations of state. It may be more convenient to install a corresponding number of prototypes and clone them rather than instantiating the class manually, each time with the appropriate state.")
        };
    }
}

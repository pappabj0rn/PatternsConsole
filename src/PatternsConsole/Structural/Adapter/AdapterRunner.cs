using System;

namespace PatternsConsole.Structural.Adapter
{
    public class AdapterRunner : PatternRunnerBase
    {
        public override void Run()
        {
            Console.WriteLine("Using ClassAdaptor.");
            var c = new ClassAdaptor();
            c.SayHelloWorld();

            Console.WriteLine("\nUsing ObjectAdaptor with new Adaptee.");
            var o = new ObjectAdaptor(new Adaptee());
            o.SayHelloWorld();
        }

        public override PatternCategory Category => PatternCategory.Structural;
        public override string Name => "Adapter";
        public override string AlsoKnownAs => "Wrapper";
        public override string PageRef => "139";

        protected override string[] ConsequencesLines => new[]
        {
            "A class adapter "+
            "\n a. adapts Adaptee to Target by committing to a concrete Adaptee class."+
            "\n b. lets Adapter override some of Adaptee's behavior."+
            "\n c. introduces only one object, and no additional pointer indirection is needed"+
            "       to get to the adaptee.",
            "An object adapter"+
            "\n a. lets a single Adapter work with meny Adaptees (adaptee + subclasses)."+
            "\n b. makes it harder to override Adaptee behavior."
        };
        protected override string[] ApplicabilityLines => new[]
        {
            "* you want to use an existing class, and its interface does not match the one",
            "  you need.",
            "* you want to create a resusable class that cooperates with unrelated or",
            "  unforeseen classes, that is, classes that don't necessarily have compatible",
            "  interfaces.",
            "* (object adapter only) you need to use several existing subclasses, but it's",
            "  impractical to adapt their interface by subclassing every one. An object",
            "  adapter cab adapt the interface of its parent class."
        };
    }
}

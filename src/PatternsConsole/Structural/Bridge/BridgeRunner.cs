namespace PatternsConsole.Structural.Bridge
{
    public class BridgeRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var abstraction = new Abstraction(new ConsoleImplementor());
            abstraction.SayHello();
        }

        public override PatternCategory Category => PatternCategory.Structural;
        public override string Name => "Bridge";
        public override string Description => BreakLine("Decouple an avstraction from its implementation so that the two can vary independently.");
        public override string AlsoKnownAs => "Handle/Body";
        public override string PageRef => "151";

        protected override string[] ConsequencesLines => new[]
        {
            "Decoupling interface and implementation.",
            "Improved extensibility.",
            "Hiding implementation details from clients."
        };
        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("you want to avoid a permanent binding between an abstraction and its implementation. This might be the case, for example, when the implementation must be selected or switched at run-time."),
            BreakLine("both the abstractions and their implementaionts should be extensible by subclassing. In this case, the Bridge pattern lets you combine the different abstractions and implementations and extend them independently."),
            BreakLine("changes in the implementation of an abstraction should have no impact on clients that is, their code should not have to be recompiled."),
            BreakLine("(C++) you want to hide the implementation of an avstraction completely from client. In C++ the representation of a class is visible in the class interface."),
            BreakLine("you have a profilation of classes as shown earlier in the first Motivation diagram. Such a class hoerarchy indicates the need for splitting an object into two parts. Rumbaugh uses the term \"nested generalizations\" [RBP+91] to refer to such class hierarchies."),
            BreakLine("you want to share an implementation among multiple objects (perhaps using reference counting), and this fact should be hidden from the clinet. A simple example is Coplien's String class [Cop92], in which multiple objects can share the same string representation (StringRep).")
        };
   }
}
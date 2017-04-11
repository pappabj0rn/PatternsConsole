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
            "you want to avoid a permanent binding between an abstraction and its implementation. This might be the case, for example, when the implementation must be selected or switched at run-time.",
            "both the abstractions and their implementaionts should be extensible by subclassing. In this case, the Bridge pattern lets you combine the different abstractions and implementations and extend them independently.",
            "changes in the implementation of an abstraction should have no impact on clients; that is, their code shouldnot have to be recompiled.",
            "(C++) you want to hide the implementation of an avstraction completely from client. In C++ the representation of a class is visible in the class interface.",
            "you have a profilation of classes as shown earlier in the first Motivation diagram. Such a class hoerarchy indicates the need for splitting an object into two parts. Rumbaugh uses the term \"nested generalizations\" [RBP+91] to refer to such class hierarchies.",
            "you want to share an implementation among multiple objects (perhaps using reference counting), and this fact should be hidden from the clinet. A simple example is Coplien's String class [Cop92], in which multiple objects cna share the same string representation (StringRep)."
        };
   }
}
using System;
using System.Collections.Generic;

namespace PatternsConsole.Behavioral.Visitor
{
    public class VisitorRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var random = new Random();

            Console.WriteLine("Seting up nodes.");

            var nodes = new List<Node>
            {
                new StringNode {Value = "Hello World"},
                new StringNode {Value = "Hello my baby"},
                new StringNode {Value = "Hello my honey"},
                new StringNode {Value = "Hello my ragtime girl"},
                new StringNode {Value = "Shut your f'in face"},
                new StringNode {Value = "Me?"},
            };

            for (var i = 0; i < random.Next(1,1000); i++)
            {
                nodes.Add(new IntNode { Value = random.Next(1, 9999999) });
            }

            var typeVisitor = new TypeCountVisitor();
            var lengthVisitor = new LengthVisitor();

            Console.WriteLine("Visiting nodes.");

            foreach (var node in nodes)
            {
                node.Accept(typeVisitor);
                node.Accept(lengthVisitor);
            }

            Console.WriteLine("Report:");
            typeVisitor.ReportFindings();
            lengthVisitor.ReportFindings();
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "Visitor";
        public override string Description => BreakLine("Represent an operation to be performed on the elements " +
                                                        "of an object structure. Visitor lets you define a new " +
                                                        "operation withou changing the classes of the elements " +
                                                        "on which it operates.");
        public override string PageRef => "331";

        public override string ApplicabilityLeadin => "Use the Visitor pattern when";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("an object structure contains many classes of objects with " +
                      "differing interfaces, and you want to perform operations on " +
                      "these objects that depend on their concrete classes."),
            BreakLine("many distinct and unrelated operations need to be performed " +
                      "on objects in an object structure, and you want to avoid " +
                      "\"polluting\" their classes with these operations. Visitor " +
                      "lets you keep related operations together by defining them " +
                      "on one class. When the object structure is shared by many " +
                      "applications, use Visitor to put operations in just those " +
                      "applications that need them."),
            BreakLine("the classes defining the object structure rarely change, but " +
                      "you often want to define new operations over the structure. " +
                      "Changing the object structure classes requires redefining the " +
                      "interface to all visitors, which is potentially costly. If " +
                      "the object structure classes change often, then it's probably " +
                      "better to define the operations in those classes.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "Visitor makes adding new operations easy.",
            "A visitor gathers related operations and separates unrelated ones.",
            "Adding new ConcreteElement classes is hard.",
            "Visiting across class hierarchies.",
            "Accumulating state.",
            "Breaking encapsulation."
        };
    }
}

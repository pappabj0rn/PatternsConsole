using System;

namespace PatternsConsole.Behavioral.Interpeter
{
    public class InterpeterRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var context = new Context();

            var x = new VariableExpression("x");
            var y = new VariableExpression("y");

            Console.WriteLine("(true and x) or (y and (not x))");

            var expression = new OrExpression(
                new AndExpression(new ConstantExpression(true),x),
                new AndExpression(y, new NotExpression(x)));

            Console.WriteLine("X\tY\tResult");

            for (var iY = 0; iY < 2; iY++)
            {
                for (var iX = 0; iX < 2; iX++)
                {
                    context.Assign(x, iX != 0);
                    context.Assign(y, iY != 0);

                    var result = expression.Evaluate(context);

                    Console.Write(context.Lookup(x.Name));
                    Console.Write("\t");
                    Console.Write(context.Lookup(y.Name));
                    Console.Write("\t");
                    Console.WriteLine(result);
                }
            }
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "Interpeter";
        public override string Description => BreakLine("Given a language, define a representation for its grammar along with " +
                                                        "an interpeter that uses the representation to interpret sentences in the language.");
        public override string PageRef => "243";

        public override string ApplicabilityLeadin => BreakLine("Use the Interpreter pattern when there is a language to interpret, and you " +
                                                                "can represent statements in the language as abstract syntax trees. The " +
                                                                "Interpreter pattern works best when"
            ,newlineStart:" ");

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("the grammar is simple. For complex grammars, the class hierarchy for the grammar " +
                      "becomes large and unmanageable. Tools such as parser generators are a better " +
                      "alternative in such cases. They can interpret expressions without building " +
                      "abstract syntax trees, wich can save space and possibly time."),
            BreakLine("efficiency is not a critical concern. The most efficient interpreters are usually " +
                      "not implemented by interpreting parse trees directly but by first translating " +
                      "them into another form. For example, regular expressions are often transformed " +
                      "into state machines. But even then, the translator can be implemented by the " +
                      "Interpreter pattern, so the pattern is still applicable.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "It's easy to change and extent the grammar.",
            "Implementing the grammar is easy, too.",
            "Complex grammars are hard to maintain.",
            "Adding new ways to interpret expressions."
        };
    }
}

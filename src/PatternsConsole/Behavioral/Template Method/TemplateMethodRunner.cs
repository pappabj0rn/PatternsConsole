namespace PatternsConsole.Behavioral.Template_Method
{
    public class TemplateMethodRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var adder = new ConsoleShoutIntAdded();
            adder.Add(3, 5);
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "Template Method";
        public override string Description => BreakLine("Define the skeleton of an algorithm in an operation, " +
                                                        "deferring some steps to subclasses. template Method " +
                                                        "lets subclasses redefine certain steps of an algorithm " +
                                                        "without changeing the algorithm's structure.");
        public override string PageRef => "325";

        public override string ApplicabilityLeadin => "The Template Method pattern should be used";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("to implement the invariant parts of an algorithm once and leave " +
                      "it up to subclasses to implement the behavior that can vary."),
            BreakLine("when common behavior among subclasses should be factored and " +
                      "localized in a common class to avoid code duplication. This is a " +
                      "good example of \"refactoring to generalize\" as described by " +
                      "Opdyke and Johnson [OJ93]. You first identify the differences in " +
                      "the existing code and then separate the differences into new " +
                      "operations. Finally, you replace the differing code with a " +
                      "template method that class one of these new operations."),
            BreakLine("to control subclasses extensions. You can define a template " +
                      "method that class \"hook\" operations (see Consequences) at " +
                      "specific points, thereby permitting extensions only at those points.")
        };

        public override string Consequences
            => "\n" + 
                BreakLine("Template methods call the following kinds of operations:\n") +
                BreakLine("* concrete operations (either on the ConcreteClass or on client classes);\n") +
                BreakLine("* concrete AbstractClass operations (i.e., operations that are generally useful to subclasses);\n") +
                BreakLine("* primitive operations (i.e., abstract operations);\n") +
                BreakLine("* factory methods (see Factory Method (107)); and\n") +
                BreakLine("* hook operations, wich provide default behavior that subclasses can " +
                          "extend if necessary. A hook operation often does nothing by default.");
    }
}
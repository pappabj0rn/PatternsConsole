using System;

namespace PatternsConsole.Behavioral.Command
{
    public class CommandRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var textDoc = new TextDocument("Some start data to work with.");

            Console.WriteLine("Initial document:");
            Console.WriteLine(textDoc.Data);

            Console.WriteLine("Adding line break as pos 11.");
            textDoc.AddCommand(new LineBreak(textDoc,11));

            Console.WriteLine(textDoc.Data);

            Console.WriteLine("Undoing last command.");
            textDoc.UndoLastCommand();

            Console.WriteLine(textDoc.Data);

            Console.WriteLine("Adding line break as pos 11.");
            textDoc.AddCommand(new LineBreak(textDoc, 11));

            Console.WriteLine(textDoc.Data);

            Console.WriteLine("Adding line break as pos 16.");
            textDoc.AddCommand(new LineBreak(textDoc, 16));

            Console.WriteLine(textDoc.Data);

            Console.WriteLine("Undoing last command.");
            textDoc.UndoLastCommand();

            Console.WriteLine(textDoc.Data);
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "Command";
        public override string AlsoKnownAs => "Action, Transaction";
        public override string Description => 
            BreakLine("Encapsulate a request as an object, thereby letting you " +
                      "parameterize clients with different requests, queue or " +
                      "log requests, and support undoable operations.");

        public override string PageRef => "233";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("parameterize objects by an action to perform, as MenuItem object did above. " +
                      "You can express such parameterization in a procedural language with a callback " +
                      "function, that is, a function that's regitered somewhere to be called at a later " +
                      "point. Command are an object-oriented replacement for callbacks."),
            BreakLine("specify, queue, and execute requests at different times. A Command object can have " +
                      "a lifetime independent of the original request. If the receiver of a request can be " +
                      "represented in an address space-independent way, than you can transfer a command " +
                      "object for the request to a different process and fulfill the request there."),
            BreakLine("support undo. The Command's Execute operation can store state for reversing its effects " +
                      "in the command itself. The Command interface must have an added Unexecute operation that " +
                      "reverses the effects of a previous call to Execute. Executed commands are stored in a " +
                      "historylist. Unlimited-level undo and redo is achieved by traversing thes list backwars " +
                      "and forwards calling Unexecute and Execute, respectively."),
            BreakLine("support logging changed so that they can be reapplied in case pf a system crash. By " +
                      "augmenting he Command interface with load and store operations, you can keep a persisten " +
                      "log of changes. Recovering from a crach involves reloading logged commands from disk and " +
                      "reexecuting them with the Execute operation."),
            BreakLine("structure a system around high-level operations built on primitives operations. Such a " +
                      "structure is common in information systems that support transactions. A transaction " +
                      "encapsulates a set of changes to data. The Command pattern offers a way to model " +
                      "transactions. Commands have a common interface, letting you invoke all transactions the " +
                      "same way. The pattern also makes it easy to extend the system withg new transactions.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "Decouples the object invoking the operation from the one that knows how to perform it.",
            "Commands can be manipulated and extended like any other object.",
            "Commands can be composited into macros.",
            "It's easy to add new commands.",
        };
    }
}
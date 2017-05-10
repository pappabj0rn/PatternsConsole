using System.Collections.Generic;
using System.Linq;

namespace PatternsConsole.Behavioral.Command
{
    public abstract class Document
    {
        protected List<Command> Commands;

        protected Document()
        {
            Commands = new List<Command>();
        }

        public void AddCommand(Command command)
        {
            Commands.Add(command);
            command.Execute();
        }

        public void UndoLastCommand()
        {
            var undoableCommand = Commands.Last() as UndoableCommand;
            if (undoableCommand == null)
                return;

            Commands.Remove(undoableCommand);
            undoableCommand.Undo();
        }

        public IEnumerable<Command> GetCommands()
        {
            return Commands;
        }
    }
}
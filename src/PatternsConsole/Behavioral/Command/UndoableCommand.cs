namespace PatternsConsole.Behavioral.Command
{
    public abstract class UndoableCommand : Command
    {
        public abstract void Undo();
    }
}
namespace PatternsConsole.Behavioral.State
{
    public abstract class ConsoleState
    {
        public abstract void Connect(ConsoleConnection cc);
        public abstract void Disconnect(ConsoleConnection cc);
        public abstract void WriteLine(string msg);
    }
}
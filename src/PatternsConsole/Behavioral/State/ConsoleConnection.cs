namespace PatternsConsole.Behavioral.State
{
    public class ConsoleConnection
    {
        public ConsoleState ConsoleState { get; set; }

        public ConsoleConnection()
        {
            ConsoleState = DisconnectedConsoleState.Instance;
        }

        public void Open()
        {
            ConsoleState.Connect(this);
        }

        public void Close()
        {
            ConsoleState.Disconnect(this);
        }

        public void WriteLine(string msg)
        {
            ConsoleState.WriteLine(msg);
        }
    }
}
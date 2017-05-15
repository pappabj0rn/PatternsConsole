using System;

namespace PatternsConsole.Behavioral.State
{
    public class ConnectedConsoleState : ConsoleState
    {
        private static ConnectedConsoleState _instance;

        public static ConnectedConsoleState Instance => _instance ?? (_instance = new ConnectedConsoleState());

        private ConnectedConsoleState()
        {

        }

        public override void Connect(ConsoleConnection cc) {}

        public override void Disconnect(ConsoleConnection cc)
        {
            cc.ConsoleState = DisconnectedConsoleState.Instance;
        }

        public override void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
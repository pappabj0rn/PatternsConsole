using System;

namespace PatternsConsole.Behavioral.State
{
    public class DisconnectedConsoleState : ConsoleState
    {
        private static DisconnectedConsoleState _instance;

        public static DisconnectedConsoleState Instance => _instance ?? (_instance = new DisconnectedConsoleState());

        private DisconnectedConsoleState()
        {

        }

        public override void Connect(ConsoleConnection cc)
        {
            cc.ConsoleState = ConnectedConsoleState.Instance;
        }
        
        public override void Disconnect(ConsoleConnection cc) {}

        public override void WriteLine(string msg)
        {
            throw new Exception("Disconnected.");
        }
    }
}
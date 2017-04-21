namespace PatternsConsole.Structural.Proxy
{
    public class ExpensiveConsoleStringProxy : ConsoleString
    {
        private ExpensiveConsoleString _proxiedObject;
        
        public override void Draw()
        {
            if(_proxiedObject==null)
                _proxiedObject = new ExpensiveConsoleString();

            _proxiedObject.Draw();
        }

        public override int Length => _proxiedObject?.Length ?? 22; // guess, or some such
    }
}
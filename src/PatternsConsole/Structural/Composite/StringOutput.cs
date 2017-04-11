using System;

namespace PatternsConsole.Structural.Composite
{
    public class StringOutput : IConsoleOutput
    {
        private readonly string _msg;

        public StringOutput(string msg)
        {
            _msg = msg;
        }

        public void Print()
        {
            Console.Write(_msg);
        }
    }
}
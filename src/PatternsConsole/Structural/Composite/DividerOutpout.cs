using System;

namespace PatternsConsole.Structural.Composite
{
    public class DividerOutpout : IConsoleOutput
    {
        private readonly string _element;
        private readonly int _length;


        public DividerOutpout(string element, int length)
        {
            _element = element;
            _length = length;
        }

        public void Print()
        {
            for (var i = 0; i < _length; i++)
            {
                Console.Write(_element);
            }
        }
    }
}
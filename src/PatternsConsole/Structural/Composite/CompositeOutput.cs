using System.Collections.Generic;

namespace PatternsConsole.Structural.Composite
{
    public class CompositeOutput : IConsoleOutput
    {
        public List<IConsoleOutput> Components { get; }

        public CompositeOutput()
        {
            Components = new List<IConsoleOutput>();
        }

        public void Print()
        {
            Components.ForEach(x=>x.Print());
        }
    }
}
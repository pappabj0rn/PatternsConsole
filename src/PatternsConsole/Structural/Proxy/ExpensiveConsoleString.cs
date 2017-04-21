using System;
using System.Threading;

namespace PatternsConsole.Structural.Proxy
{
    public class ExpensiveConsoleString : ConsoleString
    {
        public override void Draw()
        {
            Console.Write("Expensive draw");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Write(" Done");
        }

        public override int Length => 22;
    }
}
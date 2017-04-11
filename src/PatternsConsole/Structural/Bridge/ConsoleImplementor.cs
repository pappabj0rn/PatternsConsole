using System;

namespace PatternsConsole.Structural.Bridge
{
    public class ConsoleImplementor : IBridge
    {
        public void SayHelloImp()
        {
            Console.WriteLine("Hello");
        }
    }
}
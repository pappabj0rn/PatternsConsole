using System;

namespace PatternsConsole.Structural.Adapter
{
    public class Adaptee
    {
        public virtual void ConsoleWriteMsg(string msg)
        {
            Console.Write(msg);
        }
    }
}
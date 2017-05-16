using System;

namespace PatternsConsole.Behavioral.Template_Method
{
    public class ConsoleShoutIntAdded : IntAdder
    {
        protected override void AboutToAdd(int a, int b)
        {
            Console.WriteLine($"I'm about to add {a} and {b}, yo!");
        }

        protected override void Added(int a, int b, int c)
        {
            Console.WriteLine($"I've added {a} and {b} into {c}!");
        }
    }
}
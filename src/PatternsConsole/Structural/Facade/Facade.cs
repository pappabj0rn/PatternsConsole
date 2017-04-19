using System;

namespace PatternsConsole.Structural.Facade
{
    public class Facade
    {
        public int CalcSum(int a, int b)
        {
            var calc = new Calculator();
            return calc.Add(a, b);
        }

        public int CalcProduct(int a, int b)
        {
            var calc = new Calculator();
            return calc.Multiply(a, b);
        }

        public void WriteMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
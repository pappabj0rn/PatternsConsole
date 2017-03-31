using System;
using PatternsConsole.Creational.AbstractFactory.System1;
using PatternsConsole.Creational.AbstractFactory.System2;

namespace PatternsConsole.Creational.Builder
{
    public class Runner : IPatternRunner
    {
        public PatternCategory Category => PatternCategory.Creational;

        public string Name => "Builder";

        public string Consequences => "1. \n2. \n3.";

        public string Examples => "";

        public void Run()
        {
            //Build(xxx);

            //Build(xxx);
        }        

        
    }
}

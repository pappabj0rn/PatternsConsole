using System;
using PatternsConsole.Creational.AbstractFactory.System1;
using PatternsConsole.Creational.AbstractFactory.System2;

namespace PatternsConsole.Creational.AbstractFactory
{
    public class Runner : IPatternRunner
    {
        public PatternCategory Category => PatternCategory.Creational;

        public string Name => "Abstract Factory";

        public string Consequences => "1. Isolates concrete factories.\n2. Makes exchanging product families easy.\n3. Promotes consistency among products.\n4. Supporting new kinds of products is difficult.";

        public string Examples => "Maze Factory, differnent kinds of rooms, walls, doors etc. \nFactories: EnchantedMazeFactory, BombedMazeFactory.";

        public void Run()
        {

            Console.WriteLine("Creation: AbstractFactory");

            CreateProducts(System1Factory.Instance);

            CreateProducts(System2Factory.Instance);
        }        

        private static void CreateProducts(IFactory factory)
        {
            Console.WriteLine("Using factory: "+factory.GetType().Name);

            var prodA = factory.CreateProductA();
            Console.WriteLine("Prod a: " + prodA.GetType().Name);

            var prodB = factory.CreateProductB();
            Console.WriteLine("Prod b: " + prodB.GetType().Name);
        }
    }
}

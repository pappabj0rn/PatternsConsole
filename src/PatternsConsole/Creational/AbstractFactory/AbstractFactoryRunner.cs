using System;
using PatternsConsole.Creational.AbstractFactory.System1;
using PatternsConsole.Creational.AbstractFactory.System2;

namespace PatternsConsole.Creational.AbstractFactory
{
    public class AbstractFactoryRunner : PatternRunnerBase
    {
        public override PatternCategory Category => PatternCategory.Creational;

        public override string Name => "Abstract Factory";
        public override string PageRef => "87";
        public override string AlsoKnownAs => "Kit";

        protected override string[] ConsequencesLines => new []
        {
            "Isolates concrete factories.",
            "Makes exchanging product families easy.",
            "Promotes consistency among products.",
            "Supporting new kinds of products is difficult."
        };

        protected override string[] ApplicabilityLines => new []
        {
            "a system should be independent of how its products are created, composed and represented.",
            "a system should be configured with one of multiple families of products.",
            "a family of related product objects is designed to be used together, and you need to enforce this constraint.",
            "you want to provide a class library of products, and you want to reveal just their interfaces, not their implementations."
        };

        public override void Run()
        {
            CreateProducts(System1Factory.Instance);

            CreateProducts(System2Factory.Instance);
        }        

        private static void CreateProducts(IFactory factory)
        {
            Console.WriteLine("Creating product using factory: "+factory.GetType().Name);

            var prodA = factory.CreateProductA();
            Console.WriteLine("Prod a: " + prodA.GetType().Name);

            var prodB = factory.CreateProductB();
            Console.WriteLine("Prod b: " + prodB.GetType().Name);
        }
    }
}

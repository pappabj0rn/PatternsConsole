﻿using System;

namespace PatternsConsole.Creational.FactoryMethod
{
    public class FactoryMethodRunner : PatternRunnerBase
    {
        public override void Run()
        {
            Console.WriteLine("Creating creator and products.");

            var creator = new ConcreteCreator();
            var p1 = creator.CreateProduct("First Product");
            var p2 = creator.CreateProduct("Second Product");
            var p3 = creator.CreateProduct();

            foreach (var product in creator.GetProducts())
            {
                Console.WriteLine("\t" + product);
            }

            Console.WriteLine("\nDeleting " + p3);
            creator.DeleteProduct(p3);
            foreach (var product in creator.GetProducts())
            {
                Console.WriteLine("\t" + product);
            }
        }

        public override PatternCategory Category => PatternCategory.Creational;
        public override string Name => "Factory Method";
        public override string Description => BreakLine("Define an interface for creating an object, but let subclasse decide wich class to instantiate. Factory Method lets a class defer instantiation to subclasses.");
        public override string PageRef => "107";
        public override string AlsoKnownAs => "Virtual Constructor";
        protected override string[] ConsequencesLines => new[]
        {
            "Provides hooks for subclasses.",
            "Connects parallel class hierarchies."
        };
        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("a class can't anticipate the class of onjects it must create."),
            BreakLine("a class wants its subclasses to specify the objects it creates."),
            BreakLine("classes delegate responsibility to one of several helper subsclasses, and you want to localize the knowledge of which helper subclass is the delegate.")
        };
    }
}

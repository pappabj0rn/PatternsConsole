﻿using System;

namespace PatternsConsole.Creational.Builder
{
    public class BuilderRunner : PatternRunnerBase
    {
        public override PatternCategory Category => PatternCategory.Creational;

        public override string Name => "Builder";
        public override string Description => BreakLine("Separate the construction of a complex object from its representation so that the same construction process can create different representations.");
        public override string PageRef => "97";

        protected override string[] ConsequencesLines => new[]
        {
            "Lets you vary a product's internal representation.",
            "Isolates code for construction and representation.",
            "Gives you finer control over the construction and representation."
        };

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("the algorith for creating a complex object should be independent of the parts that make up the object and how they're assembled."),
            BreakLine("the construction process must allow different representations fot the object that's constructed.")
        };

        public override void Run()
        {
            Console.WriteLine("Setting up components.");
            var headerBuilder = new FancyHeaderBuilder();
            var direcor = new Director(headerBuilder);

            Console.WriteLine("Constructing header.");
            direcor.Construct("demo text");
            var header = headerBuilder.GetHeader();

            Console.WriteLine(header);
        }        

        
    }
}

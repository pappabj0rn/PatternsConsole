using System;
using Newtonsoft.Json;

namespace PatternsConsole.Behavioral.Strategy
{
    public class StrategyRunner : PatternRunnerBase
    {
        public override void Run()
        {
            const string sampleText =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In vitae massa ut nisi feugiat fermentum porta et ligula. Donec non neque vitae leo volutpat commodo. Cras interdum lacus sit amet felis convallis, ut euismod nulla venenatis. Sed laoreet blandit nunc, non gravida metus sagittis quis. Aenean ac commodo leo. Maecenas ac interdum erat. Nulla ut elit fringilla, consequat odio at, posuere ipsum.\n" +
                "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Phasellus eget dolor ultrices dui vestibulum porta.Aliquam sapien ligula, rutrum porta nulla vitae, laoreet consectetur lorem. Vivamus metus nibh, efficitur in faucibus eget, semper nec est. Phasellus semper lacinia eros et maximus. Phasellus et dignissim augue, et vulputate orci. Sed nisi neque, consectetur at tincidunt at, pulvinar non velit.\n" +
                "Etiam sed lorem lacus. Maecenas gravida eu purus sit amet maximus.Nam a nunc malesuada, accumsan nisi eu, pulvinar mi.Etiam mollis sagittis semper. Integer porta lorem quis placerat fermentum. Nam vitae tempus leo, vitae ultricies nunc. Vestibulum felis magna, aliquam dignissim erat vehicula, laoreet fermentum neque. Cras eros quam, venenatis ut mauris nec, cursus aliquam purus. Curabitur dui dolor, iaculis id congue at, cursus id lacus. Mauris tellus nisl, laoreet eu porttitor sit amet, tincidunt vitae justo.Integer quis mattis nisl, quis dignissim risus.\n" +
                "Aenean tincidunt neque arcu, quis lacinia massa lacinia sit amet.Suspendisse elementum ipsum quis orci ultrices, id congue justo vestibulum.Maecenas ultrices eros finibus massa fermentum, convallis ultrices dolor iaculis.Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Curabitur nec porta massa. Vivamus libero nisi, sollicitudin quis elit semper, feugiat iaculis orci. Fusce efficitur, odio eu bibendum sodales, libero massa iaculis neque, sed malesuada ipsum purus eget ex.Suspendisse a porta leo. Aliquam pretium velit at facilisis elementum.\n" +
                "Vivamus at dui purus. Nullam ut posuere ante, non dapibus nibh. Nunc mauris tortor, rhoncus id vestibulum eget, interdum quis neque. Duis viverra facilisis tellus, nec maximus est dapibus ac. Nulla facilisi. Vestibulum mi ipsum, vehicula non efficitur sit amet, congue ut ex.Donec at ex risus. Nullam lacinia mi ipsum, sagittis rhoncus quam iaculis non. Cras maximus elit a enim rutrum vulputate.Aliquam nisi dolor, faucibus quis ultricies vel, condimentum sed lacus. Suspendisse luctus lobortis dolor quis imperdiet. Donec consectetur pretium molestie. \n";

            var strategies = new CompressionStrategy[]
            {
                new CharacterCompressionStrategy(),
                new WordCompressionStrategy(),
                new ChunkCompressionStrategy()
            };

            for (var i = 0; i < 10; i++)
            {
                var input = sampleText;

                for (var j = 0; j < i; j++)
                {
                    input += sampleText;
                }

                Console.WriteLine($"Round {i + 1}");
                Console.WriteLine($"Input text length: {input.Length}");

                foreach (var strategy in strategies)
                {
                    var comp = new Compressor(strategy).Compress(input);
                    var json = JsonConvert.SerializeObject(comp);

                    Console.WriteLine(strategy.Name);
                    Console.WriteLine($" Tot length : {json.Length}");
                    Console.WriteLine($" Dict length: {comp.Configuration.Length}");
                    Console.WriteLine($" Comp lenght: {comp.Composition.Length}");
                    Console.WriteLine($" % of input : {Math.Round((double)json.Length / input.Length * 100.0, 2)}% \n");
                }
            }
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "Strategy";
        public override string AlsoKnownAs => "Policy";
        public override string Description => BreakLine("Define a family of algorithms, encapsulate each one, and " +
                                                        "make them interchangeable. Strategy lets the algorithm " +
                                                        "vary independently from clients that use it.");
        public override string PageRef => "315";

        public override string ApplicabilityLeadin => "Use the Strategy oattern when";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("many related clases differ only in their behaviour. Strategies provide a " +
                      "way to configure a class with one of many behaviours."),
            BreakLine("you need different variants of an algorithm. For example, you might " +
                      "define algorithms reflecting different space/time trade-offs. Strategies " +
                      "can be used when these variants are implemented as a class hierarchy of " +
                      "algorithms."),
            BreakLine("an algorithm uses data that clients shouldn't know about. Use the " +
                      "Strategy pattern to avoid exposing complex, algorithm-specifik data structures."),
            BreakLine("a class defines many behaviours, and these appear as multiple conditional " +
                      "statements in its operations- Instead of many conditionals, move related " +
                      "condition branches into their own Strategy class.")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "Families of related algorithms.",
            "An alternative to subclassing.",
            "Strategies eliminate conditional statements.",
            "A choise of implementations.",
            "Clients must be aware of different Strategies.",
            "Communication overhead between Strategy and Context.",
            "Increased number of objects."
        };
    }
}

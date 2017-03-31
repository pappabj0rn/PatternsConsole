using System;
using System.Linq;
using StructureMap;

namespace PatternsConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new Container();
            container.Configure(config =>
            {
                config.Scan(_ =>
                {
                    _.AssemblyContainingType(typeof(Program));
                    _.WithDefaultConventions();
                    _.AddAllTypesOf<IPatternRunner>();
                });
            });

            var patternRunners = container.GetAllInstances<IPatternRunner>()
                .OrderBy(x=>x.Category)
                .ThenBy(x=>x.Name)
                .ToList();

            var groupedRunners = patternRunners.GroupBy(x => x.Category)
                .ToList();

            while(true)
            {
                Console.WriteLine("Select pattern, x to exit:");
                var i = 0;

                foreach (var patternRunnerGroup in groupedRunners)
                {
                    Console.WriteLine($"Pattern category: {patternRunnerGroup.Key}");

                    foreach (var patternRunner in patternRunnerGroup)
                    {
                        Console.WriteLine($"\t{++i}: {patternRunner.Name}");
                    }
                }

                
                var selection = GetConsoleLineInput();
                if (selection == "x")
                    return;

                int patternIndex;

                if (!int.TryParse(selection, out patternIndex))
                {
                    Console.WriteLine("Failed to parse pattern id.\n");
                }
                else
                {
                    if (patternIndex < 1 || patternIndex > patternRunners.Count)
                    {
                        Console.WriteLine("Pattern id out of range.\n");
                    }
                    else
                    {
                        patternIndex--;
                        var patternRunner = patternRunners[patternIndex];

                        Console.WriteLine($"Examples:\n{patternRunner.Examples}\n");
                        Console.WriteLine($"Concequenses:\n{patternRunner.Consequences}\n");
                        patternRunner.Run();
                        Console.WriteLine("");
                    }
                }
            }
            

            
        }

        private static string GetConsoleLineInput()
        {
            Console.Write(">");
            var input = Console.ReadLine();
            Console.WriteLine("");
            return input;
        }
    }

    public interface IPatternRunner
    {
        void Run();

        PatternCategory Category { get; }
        string  Name { get; }
        string Consequences { get; }
        string Examples { get; }
    }

    public enum PatternCategory
    {
        Creational
    }
}

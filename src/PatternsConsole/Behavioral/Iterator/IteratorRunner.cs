using System;
using System.Linq;

namespace PatternsConsole.Behavioral.Iterator
{
    public class IteratorRunner : PatternRunnerBase
    {
        public override void Run()
        {
            var aggregate = new IntAggregate
            {
                Data = new[] {5, 8, 3, 9, 42}
            };

            var iterator1 = aggregate.CreateIterator();
            var iterator2 = aggregate.CreateIterator();

            Console.WriteLine("Dataset: "+aggregate.Data.Aggregate("",(cur,next)=>cur +", " +next).Trim(',', ' '));

            var i = 0;
            do
            {
                PrintIteratorsCurrentItem(iterator1, iterator2);

                Console.WriteLine("Advancing iterator1");
                iterator1.Next();

                if (i++ % 2 != 1) continue;
                Console.WriteLine("Advancing iterator2");
                iterator2.Next();

            } while (!iterator1.IsDone());
        }

        private static void PrintIteratorsCurrentItem(Iterator<int> iterator1, Iterator<int> iterator2)
        {
            Console.WriteLine("Iterator1: " + iterator1.CurrentItem());
            Console.WriteLine("Iterator2: " + iterator2.CurrentItem());
        }

        public override PatternCategory Category => PatternCategory.Behavioural;
        public override string Name => "Iterator";
        public override string AlsoKnownAs => "Cursor";
        public override string Description => BreakLine("Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.");
        public override string PageRef => "257";

        public override string ApplicabilityLeadin => "Use the Iterator pattern";

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("to access an aggregate object's contents without exposing its internal representation."),
            BreakLine("to support multiple traversals of aggregate objects."),
            BreakLine("to provide a uniform interface for traversiong different aggregate structures (that is, to support polymorphic iteration).")
        };

        protected override string[] ConsequencesLines => new[]
        {
            "It supports variations in the traversal of an aggregate.",
            "Iterator simplify the Aggregate interface.",
            "More than one traversal can be pending on an aggregate."
        };
    }
}

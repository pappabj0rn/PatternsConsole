using System;
using System.Collections.Generic;

namespace PatternsConsole.Behavioral.Visitor
{
    public class LengthVisitor : Visitor
    {
        private readonly Dictionary<int,int> _lengthCounts = new Dictionary<int, int>();

        public override void Visit(IntNode n)
        {
            CountLength(n.Value.ToString().Length);
        }

        public override void Visit(StringNode n)
        {
            CountLength(n.Value.Length);
        }

        private void CountLength(int l)
        {
            if (!_lengthCounts.ContainsKey(l))
            {
                _lengthCounts.Add(l, 0);
            }

            _lengthCounts[l]++;
        }

        public override void ReportFindings()
        {
            Console.WriteLine("Length findings:");
            foreach (var lengthCount in _lengthCounts)
            {
                Console.WriteLine($"{lengthCount.Key}: {lengthCount.Value}");
            }
        }
    }
}
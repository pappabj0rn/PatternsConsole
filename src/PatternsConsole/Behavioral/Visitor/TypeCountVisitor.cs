using System;

namespace PatternsConsole.Behavioral.Visitor
{
    public class TypeCountVisitor : Visitor
    {
        private int _intNodes = 0;
        private int _stringNodes = 0;
        

        public override void Visit(IntNode n)
        {
            _intNodes++;
        }

        public override void Visit(StringNode n)
        {
            _stringNodes++;
        }

        public override void ReportFindings()
        {
            Console.WriteLine("Counts");
            Console.WriteLine("  Ints: "+_intNodes);
            Console.WriteLine("  Strings: "+_stringNodes);
        }
    }
}
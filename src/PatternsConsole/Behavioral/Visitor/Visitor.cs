using System.Collections.Generic;

namespace PatternsConsole.Behavioral.Visitor
{
    public abstract class Visitor
    {
        public abstract void Visit(IntNode n);
        public abstract void Visit(StringNode n);

        public abstract void ReportFindings();
    }
}
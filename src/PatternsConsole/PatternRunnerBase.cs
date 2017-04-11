using System.Linq;

namespace PatternsConsole
{
    public abstract class PatternRunnerBase : IPatternRunner
    {
        public abstract void Run();

        public abstract PatternCategory Category { get; }
        public abstract string Name { get; }
        public abstract string PageRef { get; }
        public virtual string AlsoKnownAs => "";

        public virtual string Applicability
        {
            get { return ApplicabilityLines.Aggregate("", (c, n) => $"{c}\n{n}"); }
        }
        protected abstract string[] ApplicabilityLines { get; }

        public virtual string Consequences
        {
            get
            {
                var i = 1;
                return ConsequencesLines.Aggregate("", (c, n) => $"{c}\n{i++}. {n}");
            }
        }

        protected abstract string[] ConsequencesLines { get; }
        
    }
}
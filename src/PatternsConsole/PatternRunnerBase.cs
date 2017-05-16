using System.Linq;
using System.Text;

namespace PatternsConsole
{
    public abstract class PatternRunnerBase : IPatternRunner
    {
        public abstract void Run();

        public abstract PatternCategory Category { get; }
        public abstract string Name { get; }
        public virtual string Description => "";
        public abstract string PageRef { get; }
        public virtual string AlsoKnownAs => "";

        public virtual string ApplicabilityLeadin => "Use when";

        public virtual string Applicability
        {
            get { return ApplicabilityLines.Aggregate("", (c, n) => $"{c}\n* {n}"); }
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

        protected virtual string[] ConsequencesLines => new [] {""};

        protected string BreakLine(string input, string newlineStart = "  ", int lineLength = 60)
        {
            var words = input.Split(' ').ToList();

            var resultSb = new StringBuilder();
            var currentLineSb = new StringBuilder();

            while (words.Count > 0)
            {
                while (words.Count > 0 && currentLineSb.Length + words[0].Length +3 <= lineLength)
                {
                    if(currentLineSb.Length > 0)
                        currentLineSb.Append(' ');

                    currentLineSb.Append(words[0]);
                    words.RemoveAt(0);
                }

                if (words.Count <= 0)
                {
                    resultSb.Append(currentLineSb);
                    break;
                }
                    

                currentLineSb.Append('\n');
                currentLineSb.Append(newlineStart);

                resultSb.Append(currentLineSb);
                currentLineSb = new StringBuilder();
            }

            return resultSb.ToString();
        }
    }
}
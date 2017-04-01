namespace PatternsConsole
{
    public interface IPatternRunner
    {
        void Run();

        PatternCategory Category { get; }
        string  Name { get; }
        string Consequences { get; }
        string Applicability { get; }
    }
}
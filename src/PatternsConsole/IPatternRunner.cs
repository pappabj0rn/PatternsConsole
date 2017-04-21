namespace PatternsConsole
{
    public interface IPatternRunner
    {
        void Run();

        PatternCategory Category { get; }
        string  Name { get; }
        string Description { get; }
        string PageRef { get; }
        string Consequences { get; }
        string ApplicabilityLeadin { get; }
        string Applicability { get; }
        string AlsoKnownAs { get; }
    }
}
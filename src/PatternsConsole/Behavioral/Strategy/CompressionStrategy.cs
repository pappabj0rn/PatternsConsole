namespace PatternsConsole.Behavioral.Strategy
{
    public abstract class CompressionStrategy
    {
        public abstract string Name { get; }
        public abstract CompressedData Compress(string text);
        public abstract string Decompress(CompressedData data);
    }
}
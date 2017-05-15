namespace PatternsConsole.Behavioral.Strategy
{
    public class Compressor
    {
        private readonly CompressionStrategy _strategy;

        public Compressor(CompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public CompressedData Compress(string text)
        {
            return _strategy.Compress(text);
        }

        public string Decompress(CompressedData data)
        {
            return _strategy.Decompress(data);
        }
    }
}
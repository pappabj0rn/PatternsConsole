using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternsConsole.Behavioral.Strategy
{
    public class ChunkCompressionStrategy : CompressionStrategy
    {
        public override string Name => "Chunk compression";

        private const char DictionarySeparator = '|';
        private const int ChunkSize = 255;

        public override CompressedData Compress(string text)
        {
            var chunks = new Dictionary<string, int>();

            GetChunks(text, chunks);

            var dictionary = chunks
                .OrderByDescending(x => x.Value)
                .Select(x=>x.Key)
                .ToList();

            var remainder = text;
            var sb = new StringBuilder();

            while (ChunkSize <= remainder.Length)
            {
                var chunk = remainder.Substring(0, ChunkSize);
                var substitue = $"{dictionary.IndexOf(chunk)},";
                sb.Append(substitue);
                remainder = remainder.Substring(ChunkSize);
            }
            
            return new CompressedData
            {
                Composition = sb.ToString()
                    .Trim(','),
                Configuration = dictionary
                    .Aggregate("", (cur, next) => cur + DictionarySeparator + next)
                    .Trim(DictionarySeparator)
            };
        }

        private static void GetChunks(string text, Dictionary<string, int> chunks)
        {
            for (var i = 0; i + ChunkSize-1 < text.Length; i+= ChunkSize)
            {
                var chunk = text.Substring(i, ChunkSize);

                if (chunks.ContainsKey(chunk))
                {
                    chunks[chunk]++;
                    continue;
                }

                chunks.Add(chunk, 1);
            }
        }

        public override string Decompress(CompressedData data)
        {
            var dictionary = data.Configuration.Split(DictionarySeparator);

            var sb = new StringBuilder();

            foreach (var i in data.Composition)
            {
                sb.Append(dictionary[i]);
            }

            return sb.ToString();
        }
    }
}
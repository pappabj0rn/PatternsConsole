using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PatternsConsole.Behavioral.Strategy
{
    public class WordCompressionStrategy : CompressionStrategy
    {
        public override string Name => "Word compression";

        private const char DictionarySeparator = '|';

        public override CompressedData Compress(string text)
        {
            var inputParts = Regex.Split(text, @"(?<=[.,;?!\s\n])");

            var dictionary = new List<string> { ".", ",", ";", "?", "!", " ", "\n"};
            var output = new List<int>();

            foreach (var c in inputParts)
            {
                var i = -1;

                if (!dictionary.Contains(c))
                {
                    dictionary.Add(c);
                    i += dictionary.Count;
                }
                else
                {
                    i = dictionary.IndexOf(c);
                }

                output.Add(i);
            }

            return new CompressedData
            {
                Composition = output.Aggregate("", (cur, next) => cur + "," + next).TrimStart(','),
                Configuration = dictionary.Aggregate("", (cur, next) => cur + DictionarySeparator + next).TrimStart(DictionarySeparator)
            };
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
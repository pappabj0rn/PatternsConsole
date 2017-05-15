using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternsConsole.Behavioral.Strategy
{
    public class CharacterCompressionStrategy : CompressionStrategy
    {
        public override string Name => "Character compression";

        public override CompressedData Compress(string text)
        {
            var dictionary = new List<char>();
            var output = new List<int>();

            foreach (var c in text)
            {
                var i = -1;

                if(!dictionary.Contains(c))
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
                Composition = output.Aggregate("",(cur,next)=>cur+","+next).TrimStart(','),
                Configuration = dictionary.Aggregate("",(cur,next)=>cur+next)
            };
        }

        public override string Decompress(CompressedData data)
        {
            var dictionary = data.Configuration.ToList();

            var sb = new StringBuilder();

            foreach (var i in data.Composition)
            {
                sb.Append(dictionary[i]);
            }

            return sb.ToString();
        }
    }
}
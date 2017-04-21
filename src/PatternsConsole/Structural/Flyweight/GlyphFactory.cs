using System.Collections.Generic;
using System.Linq;

namespace PatternsConsole.Structural.Flyweight
{
    public class GlyphFactory
    {
        private static GlyphFactory _instance;
        private static Dictionary<string,Glyph> _glyphspool;

        private GlyphFactory()
        {
            _glyphspool = new Dictionary<string, Glyph>();
        }

        public static GlyphFactory Instance => _instance ?? (_instance = new GlyphFactory());
        public int GlyphsCount => _glyphspool.Count;
        public IEnumerable<Glyph> Glyphs => _glyphspool.Values;

        public IEnumerable<Glyph> GetGlyphs(char key)
        {
            return GetGlyphs(key.ToString());
        }

        public IEnumerable<Glyph> GetGlyphs(string key)
        {
            var k = key.Length == 1 ? key.ToLower() : key;
            
            return !_glyphspool.ContainsKey(k)
                    ? CreateGlyphs(key) 
                    : new [] { _glyphspool[k] };
        }

        private IEnumerable<Glyph> CreateGlyphs(string key)
        {
            var createdGlyphs = new List<Glyph>();

            if (key.Length == 1)
            {
                if (char.IsUpper(key[0]))
                {
                    createdGlyphs.AddRange(GetGlyphs("UC"));

                    var k = key.ToLower();
                    var g = new Character(k[0]);
                    _glyphspool.Add(k, g);
                    createdGlyphs.Add(g);

                    createdGlyphs.AddRange(GetGlyphs("LC"));
                }
                else
                {
                    var g = new Character(key[0]);
                    _glyphspool.Add(key, g);
                    createdGlyphs.Add(g);
                }
                
            }
            else
            {
                Glyph g;

                switch (key)
                {
                    case "CC":
                        g = new CaseChanger();
                        _glyphspool.Add(key, g);
                        createdGlyphs.Add(g);
                        break;
                    case "UC":
                        g = new UpperCase();
                        _glyphspool.Add(key, g);
                        createdGlyphs.Add(g);
                        break;
                    case "LC":
                        g = new LowerCase();
                        _glyphspool.Add(key, g);
                        createdGlyphs.Add(g);
                        break;
                }
            }

            return createdGlyphs;
        }

        public IEnumerable<Glyph> GetCharacterGlyphs(string input)
        {
            var glyps = new List<Glyph>();

            input.ToArray()
                .Select(GetGlyphs)
                .ToList()
                .ForEach(x=>glyps.AddRange(x));

            return glyps;
        }
    }
}
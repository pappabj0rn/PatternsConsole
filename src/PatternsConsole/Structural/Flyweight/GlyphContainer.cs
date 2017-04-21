using System.Collections.Generic;
using System.Linq;

namespace PatternsConsole.Structural.Flyweight
{
    public class GlyphContainer : Glyph, IGlyphContainer
    {
        protected List<Glyph> Children;

        public GlyphContainer()
        {
            Children = new List<Glyph>();
        }

        public override int Length => Children.Aggregate(0, (i, g) => i + g.Length);

        public override void Draw(GlyphContext context)
        {
            Children.ForEach(x=>x.Draw(context));
        }

        public Glyph Add(Glyph glyph)
        {
            Children.Add(glyph);
            return glyph;
        }

        public IEnumerable<Glyph> Add(IEnumerable<Glyph> glyphs)
        {
            var collection = glyphs as Glyph[] ?? glyphs.ToArray();

            Children.AddRange(collection);
            return collection;
        }
    }
}
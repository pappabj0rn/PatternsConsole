using System.Collections.Generic;

namespace PatternsConsole.Structural.Flyweight
{
    public interface IGlyphContainer
    {
        Glyph Add(Glyph glyph);
        IEnumerable<Glyph> Add(IEnumerable<Glyph> glyph);
        int Length { get; }
    }
}
using System;

namespace PatternsConsole.Structural.Flyweight
{
    public class Character : Glyph
    {
        private readonly char _c;

        public Character(char c)
        {
            _c = c;
        }

        public override void Draw(GlyphContext context)
        {
            Console.Write(context.Uppercase ? char.ToUpper(_c) : _c);
        }
    }
}
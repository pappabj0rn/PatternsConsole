using System;

namespace PatternsConsole.Structural.Flyweight
{
    public class LowerCase : Glyph
    {
        public override void Draw(GlyphContext context)
        {
            context.Uppercase = false;

            if (context.ForceVisual)
                Console.Write("<LC>");
        }
    }
}
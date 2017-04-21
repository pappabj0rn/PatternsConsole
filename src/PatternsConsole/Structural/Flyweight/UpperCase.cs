using System;

namespace PatternsConsole.Structural.Flyweight
{
    public class UpperCase : Glyph
    {
        public override void Draw(GlyphContext context)
        {
            context.Uppercase = true;

            if (context.ForceVisual)
                Console.Write("<UC>");
        }
    }
}
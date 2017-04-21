using System;

namespace PatternsConsole.Structural.Flyweight
{
    public class CaseChanger : Glyph
    {
        public override void Draw(GlyphContext context)
        {
            context.Uppercase = !context.Uppercase;

            if (context.ForceVisual)
                Console.Write("<CC>");
        }
    }
}
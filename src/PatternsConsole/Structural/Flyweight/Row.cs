using System;

namespace PatternsConsole.Structural.Flyweight
{
    public class Row : GlyphContainer
    {
        public override void Draw(GlyphContext context)
        {
            Children.ForEach(x => x.Draw(context));
            Console.Write("\n");
        }
    }
}
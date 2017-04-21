using System;

namespace PatternsConsole.Structural.Flyweight
{
    public class Row : GlyphContainer
    {
        public override void Draw(GlyphContext context)
        {
            if(context.ForceVisual)
                Console.Write("[");
            Children.ForEach(x => x.Draw(context));
            if (context.ForceVisual)
                Console.Write("]");
            Console.Write("\n");
        }
    }
}
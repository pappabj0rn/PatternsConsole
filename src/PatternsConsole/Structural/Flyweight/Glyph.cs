namespace PatternsConsole.Structural.Flyweight
{
    public abstract class Glyph
    {
        public abstract void Draw(GlyphContext context);

        public virtual int Length => 1;
    }
}
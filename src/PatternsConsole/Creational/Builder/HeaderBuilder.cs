namespace PatternsConsole.Creational.Builder
{
    public abstract class HeaderBuilder
    {
        public abstract void BuildStart();
        public abstract void BuildText(string text);
        public abstract void BuildEnd();

        public abstract string GetHeader();
    }
}
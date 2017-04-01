namespace PatternsConsole.Creational.Builder
{
    public class Director
    {
        private readonly HeaderBuilder _headerBuilder;

        public Director(HeaderBuilder headerBuilder)
        {
            _headerBuilder = headerBuilder;
        }

        public void Construct(string text)
        {
            _headerBuilder.BuildStart();
            _headerBuilder.BuildText(text);
            _headerBuilder.BuildEnd();
        }
    }
}
namespace PatternsConsole.Structural.Decorator
{
    public class TextMessage : StringComponent
    {
        public string Text { get; set; }

        public override string GetString() => Text;
    }
}
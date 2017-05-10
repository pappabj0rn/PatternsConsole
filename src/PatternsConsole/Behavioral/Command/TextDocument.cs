namespace PatternsConsole.Behavioral.Command
{
    public class TextDocument : Document
    {
        public string Data;

        public TextDocument(string defaultData)
        {
            Data = defaultData ?? "";
        }
    }
}
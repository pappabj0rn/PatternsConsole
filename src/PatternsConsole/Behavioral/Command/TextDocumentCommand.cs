namespace PatternsConsole.Behavioral.Command
{
    public abstract class TextDocumentCommand : UndoableCommand
    {
        protected readonly TextDocument Document;

        protected TextDocumentCommand(TextDocument document)
        {
            Document = document;
        }
    }
}
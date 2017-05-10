namespace PatternsConsole.Behavioral.Command
{
    public class LineBreak : TextDocumentCommand
    {
        private readonly int _position;

        public LineBreak(TextDocument document, int position) : base(document)
        {
            _position = position;
        }

        public override void Execute()
        {
            Document.Data =  Document.Data.Insert(_position, "\n");
        }

        public override void Undo()
        {
            Document.Data = Document.Data.Remove(_position, 1);
        }
    }
}
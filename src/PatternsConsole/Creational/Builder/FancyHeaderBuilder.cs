namespace PatternsConsole.Creational.Builder
{
    public class FancyHeaderBuilder : HeaderBuilder
    {
        private string _result = "";
        
        public override void BuildStart()
        {
            _result += "-=[ ";
        }

        public override void BuildText(string text)
        {
            _result += text;
        }

        public override void BuildEnd()
        {
            _result += " ]=-";
        }

        public override string GetHeader()
        {
            return _result;
        }
    }
}
namespace PatternsConsole.Behavioral.Mediator
{
    public class FlipPlopWidget : Widget
    {
        public static string Flip = "x";
        public static string Flop = "o";


        public FlipPlopWidget(string label) : base(label)
        {
            Value = Flop;
        }

        public void Switch()
        {
            Value = Value == Flip ? Flop : Flip;
        }
    }
}
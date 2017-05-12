using System;

namespace PatternsConsole.Behavioral.Mediator
{
    public class Mediator
    {
        private readonly StringWidget _stringWidget = new StringWidget("Name");
        private readonly FlipPlopWidget _flipFlopWidget = new FlipPlopWidget("FlipFlop");

        public Mediator()
        {
            _stringWidget.Changed += (sender, args) =>
            {
                if(sender.Value == "Trogdor")
                {
                    Console.WriteLine("Secret name => switch the flipflop.");
                    _flipFlopWidget.Switch();
                }
            };

            _flipFlopWidget.Changed += (sender, args) => {
                if (sender.Value == FlipPlopWidget.Flop)
                {
                    Console.WriteLine("[SadTrombone.wav]");
                }
            };
        }

        public void SetName(string name)
        {
            _stringWidget.Value = name;
        }

        public void SwitchFlipFlop()
        {
            _flipFlopWidget.Switch();
        }

        public string State => $"\t{_stringWidget.State}\n\t{_flipFlopWidget.State}";
    }
}
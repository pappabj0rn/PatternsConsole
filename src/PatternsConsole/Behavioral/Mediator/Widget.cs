using System;

namespace PatternsConsole.Behavioral.Mediator
{
    public abstract class Widget
    {
        public string Label { get; set; }

        private string _value;
        public event WidgetChangedEventHandler Changed;

        protected Widget(string label)
        {
            Label = label;
        }

        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnChanged(EventArgs.Empty);
            }
        }

        protected virtual void OnChanged(EventArgs e)
        {
            Changed?.Invoke(this, e);
        }

        public virtual string State => $"{Label}: {Value}";
    }
}
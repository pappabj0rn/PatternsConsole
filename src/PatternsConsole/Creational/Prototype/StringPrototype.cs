namespace PatternsConsole.Creational.Prototype
{
    public class StringPrototype : Prototype
    {
        public string String { get; set; }

        public StringPrototype()
        {
            String = "";
        }

        public override Prototype Clone()
        {
            return (Prototype) MemberwiseClone();
        }

        public override string ToString()
        {
            return String;
        }
    }
}
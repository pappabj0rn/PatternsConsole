namespace PatternsConsole.Creational.FactoryMethod
{
    public class ConcreteProduct : Product
    {
        public ConcreteProduct(string name)
        {
            Name = name;
        }

        public override string Name { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
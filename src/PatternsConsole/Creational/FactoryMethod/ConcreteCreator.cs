namespace PatternsConsole.Creational.FactoryMethod
{
    public class ConcreteCreator : Creator
    {
        protected override Product InstanciateProduct(string productName)
        {
            return new ConcreteProduct(productName ?? "Untitled product");
        }
    }
}
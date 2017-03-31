namespace PatternsConsole.Creational.AbstractFactory.System1
{
    public class System1Factory : IFactory
    {
        private static System1Factory _instance;
        private System1Factory()
        {
            
        }

        public static IFactory Instance => _instance ?? (_instance = new System1Factory());

        public IProductA CreateProductA()
        {
            return new System1ProductA { Name = "sys1 prod A" };
        }

        public IProductB CreateProductB()
        {
            return new System1ProductB { Name = "sys1 prod B" };
        }
    }
}

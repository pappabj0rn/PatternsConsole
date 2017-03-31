namespace PatternsConsole.Creational.AbstractFactory.System2
{
    public class System2Factory : IFactory
    {
        private static System2Factory _instance;
        private System2Factory()
        {

        }

        public static IFactory Instance => _instance ?? (_instance = new System2Factory());
        public IProductA CreateProductA()
        {
            return new System2ProductA { Name = "sys2 prod A" };
        }

        public IProductB CreateProductB()
        {
            return new System2ProductB { Name = "sys2 prod B" };
        }
    }
}

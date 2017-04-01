namespace PatternsConsole.Creational.Builder
{
    public class Product
    {
        public string StringProp { get; set; }

        public string Method1(string param1, string param2)
        {
            return param1 + param2;
        }
    }
}
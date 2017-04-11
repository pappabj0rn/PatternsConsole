namespace PatternsConsole.Structural.Adapter
{
    public class ObjectAdaptor : ITarget
    {
        private readonly Adaptee _adaptee;

        public ObjectAdaptor(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void SayHelloWorld()
        {
            _adaptee.ConsoleWriteMsg("Hello World");
        }
    }
}
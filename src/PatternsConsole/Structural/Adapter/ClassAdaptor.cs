namespace PatternsConsole.Structural.Adapter
{
    public class ClassAdaptor : Adaptee, ITarget
    {
        public void SayHelloWorld()
        {
            ConsoleWriteMsg("Hello World");
        }
    }
}
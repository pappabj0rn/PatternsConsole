namespace PatternsConsole.Structural.Bridge
{
    public class Abstraction
    {
        private readonly IBridge _imp;

        public Abstraction(IBridge imp)
        {
            _imp = imp;
        }

        public void SayHello()
        {
            _imp.SayHelloImp();
        }
    }
}
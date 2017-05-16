namespace PatternsConsole.Behavioral.Template_Method
{
    public abstract class IntAdder
    {
        public int Add(int a, int b)
        {
            AboutToAdd(a,b);

            var c = a + b;

            Added(a,b,c);

            return c;
        }

        protected abstract void AboutToAdd(int a, int b);
        protected abstract void Added(int a, int b, int c);
    }
}
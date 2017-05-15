namespace PatternsConsole.Behavioral.Observer
{
    public class IntSubject : Subject
    {
        private int _state;

        public int GetState()
        {
            return _state;
        }

        public void SetState(int state)
        {
            _state = state;
            Notify();
        }
    }
}
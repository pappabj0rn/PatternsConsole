using System;

namespace PatternsConsole.Behavioral.Observer
{
    public class IntObserver : Observer
    {
        public IntObserver()
        {
            Id = Guid.NewGuid();
        }

        public override void Update(Subject subject)
        {
            var intSub = subject as IntSubject;
            if (intSub == null)
                return;

            Console.WriteLine($"{Id}\n\tObserver updated: {intSub.GetState()}");
        }
    }
}
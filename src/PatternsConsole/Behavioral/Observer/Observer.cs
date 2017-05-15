using System;

namespace PatternsConsole.Behavioral.Observer
{
    public abstract class Observer
    {
        public Guid Id { get; protected set; }
        public abstract void Update(Subject subject);
    }
}
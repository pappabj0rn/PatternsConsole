using System;

namespace PatternsConsole.Creational.Singleton
{
    public class Singleton
    {
        protected Singleton()
        {
            
        }

        protected static Singleton _instance;
        public static Singleton Instance => _instance ?? (_instance = new Singleton());
        
        public virtual void SayHello()
        {
            Console.WriteLine("Hello from singleton.");
        }
    }
}
using System;

namespace PatternsConsole.Creational.Singleton
{
    public class SubSingleton : Singleton
    {
        private SubSingleton()
        {
            
        }

        public static void SetInstance()
        {
            _instance = new SubSingleton();
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello from SubSingleton.");
        }
    }
}
using System;

namespace Singleton
{
    public class MainSingleton
    {
        public void Singleton()
        {
            Console.WriteLine("Singleton - start");

            var singleton = global::Singleton.Singleton.GetInstance();
            var singletonNew = global::Singleton.Singleton.GetInstance();

            if (singleton == singletonNew)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Singleton - work!");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Singleton - not work!");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            
        }

    }
}
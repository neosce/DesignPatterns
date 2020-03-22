using System;
using Singleton;

namespace DesignPatterns.GenerativePatterns
{
    public class SingletonStart : IPatterns
    {
        string _description = "Паттерн Singleton - гарантирует, что у класса может быть только один экземпляр. " +
                              "В частном случае предоставляется возможность наличия, заранее определенного числа экземпляров.";

        public void MainCall()
        {
            Console.WriteLine("Singleton");
            Console.WriteLine(_description);
            MainSingleton mainSingleton = new MainSingleton();
            mainSingleton.Singleton();
        }
    }
}
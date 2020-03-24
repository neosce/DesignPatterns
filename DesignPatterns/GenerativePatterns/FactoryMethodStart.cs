using System;
using FactoryMethod;

namespace DesignPatterns.GenerativePatterns
{
    public class FactoryMethodStart : IPatterns
    {
        private string _description = "это порождающий паттерн проектирования, который определяет общий интерфейс для создания объектов в суперклассе, позволяя подклассам изменять тип создаваемых объектов.";

        public void MainCall()
        {
            Console.WriteLine(_description);
            
            MainFactoryMethod mainFactoryMethod = new MainFactoryMethod();
            mainFactoryMethod.FactoryMethod();
        }
    }
}
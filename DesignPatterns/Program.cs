using System;
using DesignPatterns.GenerativePatterns;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            // фабричный метод - это стратегия создания объектов
            Console.WriteLine("Hello via Design patterns");
            Console.WriteLine("Choose your category patterns");

            var patternContext = new PatternContext();

            do
            {
                Console.WriteLine("1 - Generative\n 2 - Structural\n 3 - Behavior\n 0 - EXIT\n");
                
                var str = Console.ReadLine();
                
                if (int.TryParse(str, out n) && n < 4 && n >= 0)
                {
                    switch (n)
                    {
                        case 1:
                            GetGenerativePattern.GetPattern(patternContext);
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Try once more...");
                    n = -1;
                }
                
            } while (n != 0);

        }
    }
}
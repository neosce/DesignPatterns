using System;

namespace DesignPatterns.GenerativePatterns
{
    public static class GetGenerativePattern
    {
        public static void GetPattern(PatternContext patternContext)
        {
            int n;
            
            do
            {
                Console.WriteLine("1 - Singleton\n2 - Factory Method\n 0 - Back\n");
                var str = Console.ReadLine();
                
                if (int.TryParse(str, out n) && n >= 0)
                {
                    switch (n)
                    {
                        case 1:
                            patternContext.SetPattern(new SingletonStart());
                            patternContext.StartPattern();
                            break;
                        case 2:
                            patternContext.SetPattern(new FactoryMethodStart());
                            patternContext.StartPattern();
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
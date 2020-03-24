using System;

namespace FactoryMethod.Example.SimpleMessanger
{
    public static class CheckMessage
    {
        public static void CheckMsg(string text, string source, string target)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw  new ArgumentNullException(nameof(text), "Your message is null!");
            }
            
            if (string.IsNullOrWhiteSpace(source))
            {
                throw  new ArgumentNullException(nameof(source), "UserName can't be empty!");
            }
            
            if (string.IsNullOrWhiteSpace(target))
            {
                throw  new ArgumentNullException(nameof(target), "Recipient UserName can't be empty!");
            }
            
            if (text.Length > 140)
            {
                throw  new ArgumentException("Your message over 140!");
            }
        }
    }
}
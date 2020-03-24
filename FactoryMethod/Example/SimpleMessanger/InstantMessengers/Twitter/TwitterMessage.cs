using System;

namespace FactoryMethod.Example.SimpleMessanger.InstantMessengers.Twitter
{
    /// <summary>
    /// Реализация сообщения Твиттера.
    /// Принимает длинной 140 символов.
    /// </summary>
    public class TwitterMessage: MessageBase
    {
        /// <summary>
        /// Создать новый экземпляр сообщения Твиттера. 
        /// </summary>
        /// <param name="text">Текст сообщения до 140 символов</param>
        /// <param name="source">Отправитель</param>
        /// <param name="target">Получатель</param>
        public TwitterMessage(string text, string source, string target) : base(text, source, target)
        {
            Text = text.Length <= 140 ? text : text.Substring(0, 140);
        }

        public override void Send()
        {
            Console.WriteLine($"Twitter: Твит от: @{Source} для @{Target}: {Text}");
        }
    }
}
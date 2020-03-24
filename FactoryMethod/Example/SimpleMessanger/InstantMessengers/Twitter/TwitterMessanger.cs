using System;

namespace FactoryMethod.Example.SimpleMessanger.InstantMessengers.Twitter
{
    /// <summary>
    /// Реализация мессенджера Твиттера.
    /// </summary>
    public class TwitterMessanger : MessangerBase
    {
        /// <summary>
        /// Создать экземпляр мессенджера Твиттера 
        /// </summary>
        /// <param name="userName">Логин</param>
        /// <param name="password">Пароль</param>
        public TwitterMessanger(string userName, string password) : base(userName, password)
        {
        }
        
        /// <summary>
        /// Создать сообщение готовое для отправки в Твиттер.
        /// Это фабричный метод, а есди точнее его интерфейс!
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="source">Отправитель сообщения</param>
        /// <param name="target">Получатель сообщения</param>
        /// <returns>Сообщение Твиттера, готовое к отправке.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // Сюда можно добавить функционал при необходимости
            var message = new TwitterMessage(text, source, target);
            return message;
        }
        
        /// <summary>
        /// Авторизация пользователя в Твиттере 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool Authorize()
        {
            // TODO: API to twitter for auth.
            Console.WriteLine($"Authorize in Twitter User name {UserName}");
            return true;
        }
    }
}
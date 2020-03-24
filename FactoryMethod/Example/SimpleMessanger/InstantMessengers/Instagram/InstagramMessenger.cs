using System;

namespace FactoryMethod.Example.SimpleMessanger.InstantMessengers.Instagram
{
    /// <summary>
    /// Реализация мессенджера инстаграмма.
    /// </summary>
    public class InstagramMessenger: MessangerBase
    {
        /// <summary>
        /// Создать экземпляр мессенджера Инстграмма.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public InstagramMessenger(string userName, string password) : base(userName, password)
        {
        }
        
        /// <summary>
        /// Создать сообщение готовое для отправки в инсту.
        /// This is FACTORY METHOD, а если точнее интерфейс фабричного метода, объявлен, но не реализован.
        /// </summary>
        /// <param name="text">Путь к файлу до картинки</param>
        /// <param name="source">Отправитель</param>
        /// <param name="target">Получатель</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // При необходимости можно добавить сюда лполнительные действия
            // Например, выполнять анализ изображения для их улучшения или обучения нейроных сетей.
            var message = new InstagramMessage(text, source, target);
            return message;
        }
        
        /// <summary>
        /// Авторизация пользователя в Инстаграмме
        /// </summary>
        /// <returns></returns>
        public override bool Authorize()
        {
            // TODO: обращение к API Instagram для авторизации
            Console.WriteLine($"Authorize in Instagram with: {UserName}");
            return true;
        }
    }
}
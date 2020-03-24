using System;
using System.IO;

namespace FactoryMethod.Example.SimpleMessanger.InstantMessengers.Instagram
{
    /// <summary>
    /// Реализация сообщений Инстаграмма
    /// Принимает сообщение в виде картинки
    /// </summary>
    public class InstagramMessage : MessageBase
    {
        /// <summary>
        /// Создать новый экземпялр сообщения Твиттера
        /// </summary>
        /// <param name="text">Путь к файлу изображения</param>
        /// <param name="source">Отправитель</param>
        /// <param name="target">Получатель</param>
        public InstagramMessage(string text, string source, string target) : base(text, source, target)
        {
            if (File.Exists(text))
            {
                var imageBytes = File.ReadAllBytes(text);
                var base64String = Convert.ToBase64String(imageBytes);
                Text = base64String;
            }
        }
        
        /// <summary>
        /// Отправить сообщение Инстаграмм
        /// </summary>
        public override void Send()
        {
            // TODO: Обращение к API Instagram для отправки фото
            Console.WriteLine($"Instagram: photo: {Text} to: {Source} for {Target}");
        }
    }
}
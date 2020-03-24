namespace FactoryMethod.Example.SimpleMessanger
{
    
    /// <summary>
    /// Вспомогательный абстрактный клас для сообщения,
    /// который попогает сократить количество кода и уменьшить его дублирование.
    /// Наследовать именно его  - соввсем необязательно, достаточно реализовать интерфейс IMessage.
    /// Но он помогает немного сократить количество дублируемого кода,
    /// за счет того, что не нужно объявлять свойства и конструктор.
    /// </summary>
    public abstract class MessageBase : IMessage
    {
        public string Text { get; protected set; }
        public string Target { get; set; }
        public string Source { get; }

        public MessageBase(string text, string source, string target)
        {
            CheckMessage.CheckMsg(text, source, target);
            Text = text;
            Source = source;
            Target = target;
        }

        /// <summary>
        /// Отправить сообщение
        /// </summary>
        public abstract void Send();
    }
}
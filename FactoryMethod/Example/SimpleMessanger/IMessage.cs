namespace FactoryMethod.Example.SimpleMessanger
{
    /// <summary>
    /// Базовый интерфейс реализует любой тип сообщений мессенджера
    /// Для того чтобы добавить новый тип сообщений мессенждера
    /// необходимо реализовать пару интерфейсов
    /// IMessage (current) - для типа сообщений и IMessenger - для подключения к API - мессенджера
    /// </summary>
    public interface IMessage
    {
        string Text { get; }

        string Target { get; set; }
        
        string Source { get; }

        void Send();
    }
}
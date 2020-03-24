namespace FactoryMethod.Example.SimpleMessanger
{
    /// <summary>
    /// Базовый интерфейс который должен реализовывать любой мессенджер.
    /// Для того чтобы добавить новый мессенджер, необходимо реализовывать два интерфейса:
    /// IMessanger (current) - для мессенджера и IMessage - для сообщения этого мессенджера 
    /// </summary>
    public interface IMessanger
    {
        string UserName { get; }
        string Password { get; }
        bool Connected { get; }
        IMessage CreateMessage(string text, string source, string target);
        bool Authorize();

    }
}
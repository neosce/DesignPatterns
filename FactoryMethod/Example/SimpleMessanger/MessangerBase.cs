namespace FactoryMethod.Example.SimpleMessanger
{
    /// <summary>
    /// Вспомогательный абстрактный класс мессенджера для сокращения кода.
    /// который попогает сократить количество кода и уменьшить его дублирование.
    /// Наследовать именно его  - соввсем необязательно, достаточно реализовать интерфейс IMessage.
    /// Но он помогает немного сократить количество дублируемого кода,
    /// за счет того, что не нужно объявлять свойства и конструктор.
    /// </summary>
    public abstract class MessangerBase: IMessanger
    {
        public string UserName { get; }
        public string Password { get; }
        public bool Connected { get; }
     
        protected MessangerBase(string userName, string password)
        {
            if (!(string.IsNullOrWhiteSpace(userName) && string.IsNullOrWhiteSpace(password)))
            {
                UserName = userName;
                Password = password;
                Connected = Authorize();
            }
            else
            {
                Connected = false;
            }
        }

        /// <summary>
        /// Создать сообщение готовое для отправки.
        /// Это FACTORY METHOD!!! а точнее его интерфейс, он объявлен, но не реализован.
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="source">Отправитель сообщения</param>
        /// <param name="target">Получатель сообщения</param>
        /// <returns>Сообщение готовое к отправке</returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract IMessage CreateMessage(string text, string source, string target);

        /// <summary>
        /// Выполнить авторизацию в мессенджере 
        /// </summary>
        /// <returns>Успешность авторизации</returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract bool Authorize();
    }
}
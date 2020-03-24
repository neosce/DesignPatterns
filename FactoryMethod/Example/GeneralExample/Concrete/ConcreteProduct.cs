namespace FactoryMethod.Example.GeneralExample.Concrete
{
    /// <summary>
    /// Продукт (конкретный продукт)
    /// Класс определяющий поведение конкрентного продукта.
    /// Для каждого конкретного продукта необходим свой собственный конкретный создатель.
    /// Конкретных продуктов может быть много.
    ///
    /// В рассмотренном нами примере это были конкретные реализации типов сообщений TwitterMessage, InstagraMessage 
    /// </summary>
    public class ConcreteProduct : IProduct
    {
        public string Name { get; set; }
        public void DoWork()
        {
            //Magic
        }
    }
}
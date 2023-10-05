namespace AbstractFactory
{
    //abstract factory
    internal interface IFactory
    {
        IProdutoA CrearA();
        IProdutoB CrearB();
    }
}

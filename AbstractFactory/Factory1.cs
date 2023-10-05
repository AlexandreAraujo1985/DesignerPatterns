namespace AbstractFactory
{
    internal class Factory1 : IFactory
    {
        public IProdutoA CrearA() => new ProdutoA1();

        public IProdutoB CrearB() => new ProdutoB1();
    }
}

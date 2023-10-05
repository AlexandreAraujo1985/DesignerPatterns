namespace AbstractFactory
{
    internal class ProdutoB1 : IProdutoB
    {
        public void TestB()
        {
            Console.WriteLine($"Teste {nameof(ProdutoB1)}");
        }
    }
}
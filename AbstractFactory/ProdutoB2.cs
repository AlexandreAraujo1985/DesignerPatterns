namespace AbstractFactory
{
    internal class ProdutoB2 : IProdutoB
    {
        public void TestB()
        {
            Console.WriteLine($"Teste {nameof(ProdutoB2)}");
        }
    }
}
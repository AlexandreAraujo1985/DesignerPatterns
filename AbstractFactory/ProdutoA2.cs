namespace AbstractFactory
{
    internal class ProdutoA2 : IProdutoA
    {
        public void TestA()
        {
            Console.WriteLine($"Teste {nameof(ProdutoA2)}");
        }
    }
}
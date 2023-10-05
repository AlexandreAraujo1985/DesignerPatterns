namespace AbstractFactory
{
    internal class ProdutoA1 : IProdutoA
    {
        public void TestA()
        {
            Console.WriteLine($"Teste {nameof(ProdutoA1)}");
        }
    }
}
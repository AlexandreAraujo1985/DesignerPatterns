// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AbstractFactory;

void TestFactory(IFactory factory)
{
    IProdutoA produtoA = factory.CrearA();
    IProdutoB produtoB = factory.CrearB();

    produtoA.TestA();
    produtoB.TestB();
}

TestFactory(new Factory1());
TestFactory(new Factory2());

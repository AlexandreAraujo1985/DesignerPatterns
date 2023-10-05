using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Factory2 : IFactory
    {
        public IProdutoA CrearA() => new ProdutoA2();

        public IProdutoB CrearB() => new ProdutoB2();
    }
}

using ProdutosXMLConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosXMLConsoleApp.Interfaces
{
    internal interface IProdutoRepository
    {
        void Exportar(Produto produto);
    }
}

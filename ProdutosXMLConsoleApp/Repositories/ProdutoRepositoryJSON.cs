using Newtonsoft.Json;
using ProdutosXMLConsoleApp.Entities;
using ProdutosXMLConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosXMLConsoleApp.Repositories
{
    public class ProdutoRepositoryJSON : IProdutoRepository
    {
        public void Exportar(Produto produto)
        {
            var json = JsonConvert.SerializeObject(produto, Formatting.Indented);

            var streamWriter = new StreamWriter("C:\\temp\\produto.json");

            streamWriter.Write(json);

            streamWriter.Close();
        }
    }
}

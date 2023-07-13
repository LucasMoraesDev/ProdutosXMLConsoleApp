using ProdutosXMLConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProdutosXMLConsoleApp.Repositories
{
    public class ProdutoRepository
    {

        public void Exportar(Produto produto)
        {
            var xmlSerializer = new XmlSerializer(typeof(Produto));

            var streamWriter = new StreamWriter("C:\\temp\\produto.xml");

            xmlSerializer.Serialize(streamWriter, produto);

            streamWriter.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosXMLConsoleApp.Entities
{
    public class Fornecedor
    {
        private Guid _idFornecedor;
        private string _nome;
        private string _cnpj;

        public Fornecedor()
        {
            _idFornecedor = Guid.NewGuid();
        }
        public Guid IdFornecedor { get => _idFornecedor; set => _idFornecedor = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cnpj { get => _cnpj; set => _cnpj = value; }
    }
}

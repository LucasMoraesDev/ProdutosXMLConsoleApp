using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosXMLConsoleApp.Entities
{
    public class Produto
    {
        private Guid _idProduto;
        private string _nome;
        private double _preco;
        private int _quantidade;
        private DateTime _dataCompra;
        private Fornecedor _fornecedor;
        private Categoria _categoria;

        public Produto()
        {
            _idProduto = Guid.NewGuid();
        }

        public Guid IdProduto { get => _idProduto; set => _idProduto = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public DateTime DataCompra { get => _dataCompra; set => _dataCompra = value; }
        public Fornecedor Fornecedor { get => _fornecedor; set => _fornecedor = value; }
        public Categoria Categoria { get => _categoria; set => _categoria = value; }
    }
}

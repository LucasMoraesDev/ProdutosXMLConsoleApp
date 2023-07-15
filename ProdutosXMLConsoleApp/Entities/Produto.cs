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

        public Guid IdProduto
        {
            get => _idProduto;
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("O Id do produto é obrigatório.");

                _idProduto = value;
            }
        }
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6 || value.Length > 150)
                    throw new ArgumentException("O nome do produto deve ter entre 6 e 150 caracteres.");

                _nome = value;
            }
        }
        public double Preco
        {
            get => _preco;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("O preço do produto deve ser maior que zero.");

                _preco = value;
            }
        }
        public int Quantidade
        {
            get => _quantidade;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("A quantidade do produto deve ser maior que zero.");

                _quantidade = value;
            }
        }
        public DateTime DataCompra
        {
            get => _dataCompra;
            set
            {
                if (value == DateTime.MinValue)
                    throw new ArgumentException("A data de compra do produto é obrigatória.");

                _dataCompra = value;
            }
        }
        public Fornecedor Fornecedor { get => _fornecedor; set => _fornecedor = value; }
        public Categoria Categoria { get => _categoria; set => _categoria = value; }
    }
}

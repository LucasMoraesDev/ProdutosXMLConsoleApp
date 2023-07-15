using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public Guid IdFornecedor
        {
            get => _idFornecedor;
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("O Id do fornecedor é obrigatório.");

                _idFornecedor = value;
            }
        }
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6 || value.Length > 150)
                    throw new ArgumentException("O nome do fornecedor deve ter entre 6 e 150 caracteres.");

                _nome = value;
            }
        }
        public string Cnpj
        {
            get => _cnpj;
            set
            {
                if (!Regex.IsMatch(value, @"^\d{14}$"))
                    throw new ArgumentException("O CNPJ do fornecedor deve conter exatamente 14 dígitos numéricos.");

                _cnpj = value;
            }
        }
    }
}

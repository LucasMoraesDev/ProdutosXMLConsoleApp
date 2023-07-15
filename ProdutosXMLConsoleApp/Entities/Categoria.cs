using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosXMLConsoleApp.Entities
{
    public class Categoria
    {
        private Guid _idCategoria;
        private string _descricao;

        public Categoria()
        {
            _idCategoria = Guid.NewGuid();
        }
        public Guid IdCategoria
        {
            get => _idCategoria;
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("O Id da categoria é obrigatório.");

                _idCategoria = value;
            }
        }
        public string Descricao
        {
            get => _descricao;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6 || value.Length > 150)
                    throw new ArgumentException("A descrição da categoria deve ter entre 6 e 150 caracteres.");

                _descricao = value;
            }
        }
    }
}

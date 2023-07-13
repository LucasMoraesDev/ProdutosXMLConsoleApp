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
        public Guid IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
    }
}

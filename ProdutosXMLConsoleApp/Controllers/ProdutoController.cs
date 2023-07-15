using ProdutosXMLConsoleApp.Entities;
using ProdutosXMLConsoleApp.Interfaces;
using ProdutosXMLConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controllers
{
    public class ProdutoController
    {
        //método para realizar o processo de cadastro de um produto
        // informado pelo usuário do sistema através do prompt do DOS
        public void CadastrarProduto()
        {
            Console.WriteLine("\n\t*** CADASTRO DE PRODUTO ***");

            //criando um objeto para a classe Produto
            var produto = new Produto();

            try //tentativa
            {
                Console.Write("\tINFORME O NOME DO PRODUTO........: ");
                produto.Nome = Console.ReadLine();

                Console.Write("\tINFORME O PREÇO..................: ");
                produto.Preco = double.Parse(Console.ReadLine());

                Console.Write("\tINFORME A QUANTIDADE.............: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                Console.Write("\tDATA DE COMPRA...................: ");
                produto.DataCompra = DateTime.Parse(Console.ReadLine());

                var fornecedor = new Fornecedor();
                Console.Write("\tNOME DO FORNECEDOR...............: ");
                fornecedor.Nome = Console.ReadLine();

                Console.Write("\tCNPJ DO FORNECEDOR...............: ");
                fornecedor.Cnpj = Console.ReadLine();

                produto.Fornecedor = fornecedor;

                var categoria = new Categoria();
                Console.Write("\tCATEGORIA........................: ");
                categoria.Descricao = Console.ReadLine();

                produto.Categoria = categoria;


                Console.Write("\nESCOLHA XML OU JSON..: ");
                var opcao = Console.ReadLine();

                IProdutoRepository produtoRepository = null;

                switch (opcao)
                {
                    case "XML":
                        produtoRepository = new ProdutoRepositoryXML();
                        break;
                    case "JSON":
                        produtoRepository = new ProdutoRepositoryJSON();
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }

                produtoRepository.Exportar(produto);

                Console.WriteLine("\n\tARQUIVO XML GRAVADO COM SUCESSO!");
            }
            catch (Exception e) //captura do erro / exceção
            {
                Console.WriteLine("\n\tFalha ao cadastrar o produto!");
                Console.WriteLine("\tErro: " + e.Message);
            }

        }
    }
}

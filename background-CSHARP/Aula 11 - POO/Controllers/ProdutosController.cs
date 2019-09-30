using System;
using System.IO;
using Aula_1___POO.Models;
namespace Aula_1___POO.Controllers {
    public class ProdutosController {

        ProdutosModel produto = new ProdutosModel ();
        public void CadastraProduto () {

            try {
                Console.WriteLine ("Digite o ID do produto: ");
                produto.IdProduto = int.Parse (Console.ReadLine ());

                Console.WriteLine ("Digite o nome do Produto");
                produto.NomeProduto = Console.ReadLine ();

                Console.WriteLine ("Digite a descrição do Produto");
                produto.Descricao = Console.ReadLine ();

                Console.WriteLine ("Digite o preço do Produto");
                produto.Preço = double.Parse (Console.ReadLine ());

                // System.Console.WriteLine ("Digite o ID do fornecedor");
                // produto.Fornecedor.IdFornecedor = int.Parse (Console.ReadLine ());

                // Console.WriteLine ("Digite o nome do fornecedor");
                // produto.Fornecedor.NomeFornecedor = Console.ReadLine ();
            } catch (Exception ex) {

                Console.WriteLine("Deu erro na aplicação :(");
                SalvarErros(ex);
            }
        }

        public void ExibirProduto () {
            Console.WriteLine (produto.IdProduto);
            Console.WriteLine (produto.NomeProduto);
            Console.WriteLine (produto.Descricao);
            Console.WriteLine (produto.Preço);

            // Console.WriteLine (produto.Fornecedor.IdFornecedor);
            // Console.WriteLine (produto.Fornecedor.NomeFornecedor);
        }

        private void SalvarErros (Exception ex) {
            StreamWriter txt = new StreamWriter ("erro_log_txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();
            txt.Close ();

        }
    }
}
using System;
using Aula_1___POO.Controllers;

namespace Aula_1___POO {
    class Program {
        static void Main (string[] args) {
            ProdutosController produto1 = new ProdutosController ();

            produto1.CadastraProduto();

            produto1.ExibirProduto();

        }
    }
}
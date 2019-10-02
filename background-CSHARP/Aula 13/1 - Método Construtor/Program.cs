using System;
using System.Collections.Generic;
using Metodo_Construtor.Model;

namespace _1___Método_Construtor {
    class Program {
        static void Main (string[] args) {
            //Instanciamos nossa classe com o método cocnstrutor passando os parâmetros
            ProdutoModel produto = new ProdutoModel (1, "Maçã", "Verde", 3.50);
            // Chamamos um atributo do objeto instanciado
            Console.WriteLine (produto.NomeProduto);
            //instanciamos nossa classe sem passar parametros utilizando sobrecarga
            ProdutoModel produto_sobrecarga = new ProdutoModel ();
            //Alimentamos nosso objeto que estava vazio
            produto_sobrecarga.IdProduto = 1;
            produto_sobrecarga.NomeProduto = "Melão";
            produto_sobrecarga.Descricao = "Amarelo";
            produto_sobrecarga.Preco = 5.50;

            // Chamanmos a nossa lista que vai se ddo objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel> ();

            prod.Add (new ProdutoModel (1, "Cenoura", "Laranja", 2.30));
            prod.Add (new ProdutoModel (2, "Mamão", "Laranja", 2.30));
            prod.Add (new ProdutoModel (3, "Beterraba", "Laranja", 2.30));
            prod.Add (new ProdutoModel (4, "Pastel", "Laranja", 2.30));
            prod.Add (new ProdutoModel (5, "Caldo de Cana", "Laranja", 2.30));
            prod.Add (new ProdutoModel (6, "Chuchu", "Laranja", 2.30));
            //lemos os dados da nossa lista
            foreach (ProdutoModel p in prod) {
                Console.WriteLine ();
                Console.WriteLine (p.IdProduto);
                Console.WriteLine (p.NomeProduto);
                Console.WriteLine (p.Descricao);
                Console.WriteLine (p.Preco);
                Console.WriteLine ();
            }
            //Criamos um atributo especifico
            Console.WriteLine (prod[4].NomeProduto);

        }
    }
}
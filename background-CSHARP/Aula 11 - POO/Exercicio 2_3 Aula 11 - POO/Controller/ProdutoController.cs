using System;
using Exercicio_2_3_Aula_11___POO.Models;
namespace Exercicio_2_3_Aula_11___POO.Controller {
    public class ProdutoController {
        ProdutoModel mod = new ProdutoModel ();
        public void ReservaProduto () {
            // public string abc = "";
            Console.WriteLine ("Qual produto deseja reservar?");
            mod.produto = Console.ReadLine ();

            Console.WriteLine ("Você deseja reservar esse produto? Digite sim ou não.");
            string reserv = Console.ReadLine ();

            if (reserv == "sim") {
                mod.reservado = true;
            } else {
                mod.reservado = false;
            }

        }
        public string Producto() {
            return mod.produto;
        }
        public string statusReservado () {
            if (mod.reservado == true) {
                return "está reservado!!";
            } else {
                return "não está reservado.";
            }
        }
    }
}
using System;
using Exercicio_2_3_Aula_11___POO.Controller;

namespace Exercicio_2._1_Aula_11___POO {
    class Program {
        static void Main (string[] args) {
            ProdutoController control = new ProdutoController ();

            control.ReservaProduto ();
            Console.WriteLine ($"O seu produto '{control.Producto()}' {control.statusReservado()}");
        }
    }
}
using System;
using System.Linq;
namespace Exercicio_5 {
    class Program {
        static void Main (string[] args) {
            double[] valor = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine (SomaDeValores (valor));
        }
        static double SomaDeValores (double[] valor) {
            double soma;
            soma = valor.Sum ();

            return soma;
        }
    }
}
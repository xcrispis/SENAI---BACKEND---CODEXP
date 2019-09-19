using System;

namespace Exercicio_4___5 {
    class Program {
        static void Main (string[] args) {
            int valor;
            double valor1;
            double salarios = 0;

            Console.WriteLine ("Quantos funcionários tem sua empresa?");
            valor = int.Parse (Console.ReadLine ());

            for (int i = 0; i < valor; i++) {

                Console.WriteLine ("Quanto você ganha?");
                valor1 = double.Parse (Console.ReadLine ());

                salarios = salarios + valor1;

            }

            Console.WriteLine($"Média dos salarios = {salarios/valor}");

        }
    }
}
using System;

namespace Exercicio_Condicional_3 {
    class Program {
        static void Main (string[] args) {
            double v1, v2;

            Console.WriteLine ("Valor 1: ");
            v1 = double.Parse(Console.ReadLine ());

            Console.WriteLine ("Valor 2: ");
            v2 = double.Parse(Console.ReadLine ());

            if (v1 > v2) {
                Console.WriteLine($"Seu valor é {v1}");
            } else {
                Console.WriteLine($"Seu valor é {v2}");
            }
        }
    }
}
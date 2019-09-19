using System;

namespace exercicio_condicional_4 {
    class Program {
        static void Main (string[] args) {
            double v1;

            Console.WriteLine ("Qual o seu valor?");
            v1 = double.Parse (Console.ReadLine ());

            if (v1 >= 100 && v1 <= 1000) {
               v1 = v1 - v1 * 0.15;
            }
            Console.WriteLine($"O seu novo valor é: {v1}");
        }
    }
}
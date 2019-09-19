using System;

namespace Exercicio_loop___4 {
    class Program {
        static void Main (string[] args)

        {
            int valor = -1;

            for (int i = 0; i < 50; i++) {
                valor = valor + 2;
                Console.WriteLine (valor);
            }
        }
    }
}
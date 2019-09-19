using System;

namespace Exercicios_4 {
    class Program {
        static void Main (string[] args) {

            int valor = 0;
            
            for (int i = 0; i < 100; i++) {

                valor++;
                Console.WriteLine (valor*valor*valor);

            }
        }
    }
}
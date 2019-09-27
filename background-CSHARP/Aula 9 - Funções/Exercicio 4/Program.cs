using System;

namespace Exercicio_4 {
    class Program {
        static void Main (string[] args) {
            int[] valores = { 2, 8, 9, 0 };
            Vetor (valores);

        }

        static void Vetor (int[] maior, int max = 0) {
            for (int i = 0; i < maior.Length; i++) {

                if (max == 0) {
                    max = maior[0];
                } else if (maior[i] > max) {
                    max = maior[i];
                }

            }
            Console.WriteLine ($"Seu valor é {max}");

        }
    }
}
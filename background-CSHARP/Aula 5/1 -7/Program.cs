using System;

namespace _1__7 {
    class Program {
        static void Main (string[] args) {
            int[] v1 = new int[10];
            int v2 = 0;
            int indice = 0;

            for (int i = 0; i < 10; i++) {
                Console.WriteLine ("Escreva seu valor: ");
                v1[i] = int.Parse (Console.ReadLine ());

                if (v1[i] > v2) {
                    v2 = v1[i];
                    indice = i;
                }
            }
            Console.WriteLine ($"Seu maior valor é: {v2} e sua posição {indice}!");
        }
    }
}
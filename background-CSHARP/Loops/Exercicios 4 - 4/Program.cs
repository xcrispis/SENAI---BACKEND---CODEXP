using System;

namespace Exercicios_4___4 {
    class Program {
        static void Main (string[] args) {
            int valor1;
            int valor2 = 0;
            int valor3 = 0;
            string valores = "";

            for (int i = 0; i < 20; i++) {
                Console.WriteLine ("Digite seu numero: ");
                valor1 = int.Parse (Console.ReadLine ());

                if (valor1 >= 0) {
                    valores += valor1.ToString() + " ";
                } else {
                    valor2++;
                    valor3 = valor3 + valor1;
                }

            }

            Console.WriteLine (valores);

            Console.WriteLine ($"{valor3/valor2}");
        }
    }
}
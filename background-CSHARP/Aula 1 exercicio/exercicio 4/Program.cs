using System;

namespace exercicio_4 {
    class Program {
        static void Main (string[] args) {
            float dolar;
            float real;

            dolar = 4.15f;
            Console.WriteLine ("Insira valor dos bonoros: ");
            real = float.Parse (Console.ReadLine ());

            float conversao;
            conversao = real / dolar;

            Console.WriteLine($"Você vai receber a incrivel quantia de: {conversao}");
            

        }
    }
}
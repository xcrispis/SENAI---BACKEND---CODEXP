using System;
using System.Linq;

namespace Exercicio_Loop___1 {
    class Program {
        static void Main (string[] args) {
            float[] idade = new float[15];
            string[] nome = new string[15];

            for (int i = 0; i < idade.Length; i++) {

                Console.WriteLine ("Qual seu nome?");
                nome[i] =  Console.ReadLine ();

                Console.WriteLine ("Qual sua altura?");
                idade[i] = float.Parse (Console.ReadLine ());
            }


        Console.WriteLine(idade.Sum() / 15);
        }
    }
}
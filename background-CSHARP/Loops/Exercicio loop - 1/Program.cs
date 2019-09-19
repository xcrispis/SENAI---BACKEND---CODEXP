using System;
using System.Linq;

namespace Exercicio_loop___2 {
    class Program {
        static void Main (string[] args) {
            int[] idosos = new int[9];

            for (int i = 0; i < idosos.Length; i++) {
                Console.WriteLine ("Qual a população da cidade?");
                idosos[i] = int.Parse(Console.ReadLine ());
            }

            Console.WriteLine(idosos.Sum());
        }
    }
}
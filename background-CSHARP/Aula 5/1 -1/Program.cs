using System;

namespace _1__1 {
    class Program {
        static void Main (string[] args) {
            int[] series1 = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.WriteLine ("Digite um valor: ");
                series1[i] = int.Parse(Console.ReadLine ());

            }



            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine (series1[i]);
            }

            Console.WriteLine(series1[9]*5);

        }
    }
}
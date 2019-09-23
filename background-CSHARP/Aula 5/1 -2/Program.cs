using System;

namespace _1__2 {
    class Program {
        static void Main (string[] args) {
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int[] v3 = new int[20];
            for (int i = 0; i < 20; i++) {
                if (i < 10) {
                    Console.WriteLine ("Digite seu numero: ");
                    v1[i] = int.Parse (Console.ReadLine ());
                    Console.WriteLine ("Digite seu numero: ");
                    v2[i] = int.Parse (Console.ReadLine ());
                    v3[i] = v1[i];
                }
                if (i > 9) {
                    v3[i] = v2[i - 10];
                }
            }
            for (int x = 0; x < 20; x++) {
                Console.WriteLine (v3[x]);
            }
        }
    }
}
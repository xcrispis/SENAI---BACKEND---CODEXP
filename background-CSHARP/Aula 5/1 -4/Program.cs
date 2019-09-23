using System;

namespace _1__4 {
    class Program {
        static void Main (string[] args) {
            string[] v1 = new string[15];
            string[] v2 = new string[15];
            string[] v3 = new string[30];
            for (int i = 0; i < 30; i++) {
                if (i <= 14) {
                    Console.WriteLine ("Digite sua palavra: ");
                    v1[i] = (Console.ReadLine ());
                    Console.WriteLine ("Digite sua palavra: ");
                    v2[i] = (Console.ReadLine ());
                    v3[i] = v1[i];
                }
                if (i > 14) {
                    v3[i] = v2[i - 15];
                }
            }
            for (int x = 0; x < 30; x++) {
                Console.Write ($"{v3[x]}, ");
            }
        }
    }
}
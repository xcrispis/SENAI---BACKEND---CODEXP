using System;

namespace background_CSHARP {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Digite seu numero ");
            int reader = int.Parse(Console.ReadLine());
            reader = reader*3;
            Console.WriteLine($"Seu nummero é {reader}");
        }
    }
}
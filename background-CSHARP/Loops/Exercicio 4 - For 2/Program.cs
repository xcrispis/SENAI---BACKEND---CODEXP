using System;

namespace Exercicio_4___For_2 {
    class Program {
        static void Main (string[] args) {
            int valor1 = 0;
            int valor2 = 0;
            

            for (int i = 0; i < 10; i++) {
               Console.WriteLine("Insira o valor da tabuada: ");
               valor1 = int.Parse(Console.ReadLine());
               while (valor2 < 10)
               {
                   valor2++;
                   Console.WriteLine($"{valor1} X {valor2} = {valor1*valor2} ");
               }
               
            }
        }
    }
}
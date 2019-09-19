using System;

namespace Exercicio_4___While_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0;
            

            while (valor2 < 10) {
               Console.WriteLine("Insira o valor da tabuada: ");
               valor1 = int.Parse(Console.ReadLine());
               valor2++;
               while (valor2 <10)
               {
                   valor2++;
                   Console.WriteLine($"{valor1} X {valor2} = {valor1*valor2}");
               }
               
            }
        }
    }
}

using System;

namespace Exercicios_4___3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2 = 0;

            Console.WriteLine("Digite o valor: ");
            valor1  = int.Parse(Console.ReadLine());

            for (int i = 0; i < valor1; i++)
            {
                valor2++;
                Console.WriteLine(valor2*5);
            }
        }
    }
}

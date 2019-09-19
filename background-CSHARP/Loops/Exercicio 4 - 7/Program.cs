using System;

namespace Exercicio_4___7
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2 = 0;
            int valor3 = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor: ");
                valor1 = int.Parse(Console.ReadLine());

                if (valor1 % 2 != 0 )
                {
                    valor2 = valor2 + valor1;
                }

                if (valor1 % 3 == 0)
                {
                    valor3 *= valor1;  
                }
            }
            

            Console.WriteLine(valor2);
            Console.WriteLine(valor3);
        }
    }
}

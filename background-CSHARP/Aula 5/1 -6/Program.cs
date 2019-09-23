using System;

namespace _1__6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[2];
            int[] v2 = new int[2];
            int[] v3 = new int[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite seu valor 1: ");
                v1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu valor 2: ");
                v2[i] = int.Parse(Console.ReadLine());

                v3[i] = v1[i] + v2[i];   
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Seu valor do terceiro array é:  {v3[i]}");
            }
        }
    }
}

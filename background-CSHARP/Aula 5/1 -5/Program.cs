using System;

namespace _1__4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vet1[i] = i*2;
                Console.WriteLine(vet1[i]);
            }
        }
    }
}
using System;

namespace exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int passageiros;
            float valorfinal;
            
            Console.WriteLine("Quantos passageiros entraram no busão:");
            passageiros = int.Parse(Console.ReadLine());

            valorfinal = passageiros*4.30f;

            Console.WriteLine($"Seu valor final é {valorfinal}");
        }
    }
}

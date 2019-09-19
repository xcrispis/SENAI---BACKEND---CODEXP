using System;

namespace Exercicio_condicional_2
{
    class Program
    {
        static void Main(string[] args)
        {
           double valor;

        Console.WriteLine("Quanto você gastou?");
        valor = double.Parse(Console.ReadLine());

        if (valor < 100) {
           valor = valor - 25;
        }

        Console.WriteLine($"Seu valor final é = {valor}");

        }
    }
}

using System;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float divida;
            float resultado;

            Console.WriteLine("Qual seu salário?");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua divida?");
            divida = float.Parse(Console.ReadLine());

            resultado = salario - divida;

            Console.WriteLine($"O seu resultado final será {resultado}");


        }
    }
}

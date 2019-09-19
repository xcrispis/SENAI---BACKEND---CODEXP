using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
          double salario;
          double vendas;
          double final;

          Console.WriteLine("qual seu salário?:");
          salario = double.Parse(Console.ReadLine());

          Console.WriteLine("Quanto você fez em vendas?:");
          vendas = double.Parse(Console.ReadLine());

          final = salario + (vendas*1.05);

          Console.WriteLine($"O seu salário esse mês é {final}");


        }
    }
}

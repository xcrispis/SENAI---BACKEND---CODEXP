using System;

namespace exercicio_5 {
    class Program {
        static void Main (string[] args) {
            string nome;
            float salario;
            float vendas;
            float comissao;
            float total;

            Console.WriteLine ("Seu nome é:");
            nome = Console.ReadLine ();

            Console.WriteLine ("Seu salário fixo é: ");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine ("Seu valor em vendas é: ");
            vendas = float.Parse(Console.ReadLine());

            comissao = vendas * 0.10f;
            total = salario + comissao;
            Console.WriteLine($"Seu nome é {nome}, e você receberá {salario} de salário fixo, e seu salário total é {total} ");
        }
    }
}
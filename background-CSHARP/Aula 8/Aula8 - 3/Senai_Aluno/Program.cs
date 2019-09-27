using System;
using Senai_Aluno;
namespace Senai_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel1 aluno = new AlunoModel1();
            Console.WriteLine("Insira seu nome: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Insira seu curso: ");
            aluno.Curso = Console.ReadLine();
            Console.WriteLine("Insira seu RA: ");
            aluno.RA = Console.ReadLine();
            Console.WriteLine("Insira sua IDADE: ");
            aluno.Idade = Console.ReadLine();

            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Nome: " + aluno.Curso);
            Console.WriteLine("Nome: " + aluno.Ra);
            Console.WriteLine("Nome: " + aluno.Idade);


        }
    }
}

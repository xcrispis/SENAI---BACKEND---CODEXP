using System;

namespace Exercicio_3 {
    class Program {
        static void Main (string[] args) {
            string nome;
            string sobrenome;
            int idade;
            double peso;
            double altura;

            Console.WriteLine ("Digite seu nome: ");
            nome = Console.ReadLine ();

            Console.WriteLine ("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine ();

            Console.WriteLine ("Digite sua idade: ");
            idade = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite seu peso: ");
            peso = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite sua altura: ");
            altura = double.Parse (Console.ReadLine ());

            Console.WriteLine(MostraInfo());
            Console.WriteLine(MostraInfo(nome, sobrenome));
            Console.WriteLine(MostraInfo(idade, peso, altura));
           
        }

        static string MostraInfo() {
            return "RAZÃO SOCIAL SENAI";
        }

        static string MostraInfo(string nome, string sobrenome) {
         return $"{nome} {sobrenome}";
        }

        static string MostraInfo(int idade, double peso, double altura) {
           return $"Sua idade {idade}, seu peso {peso}, sua altura {altura}";
        }

    }
}
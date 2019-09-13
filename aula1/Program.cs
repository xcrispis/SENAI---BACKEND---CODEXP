using System;

namespace backend {
    class Program {
        static void Main (string[] args) {
            //somente declaramos sem atribuir valor
            int num1;

            //declaramos atribuindo um valor
            int num2 = 5;
            //variaveis do mesmo tipo
            int num3, num4, num5 = 7;
            //Variavel do tme decimal (real)
            float media;
            //bool
            bool resultado = false;
            //Escreva em uma linha, quebrando-a
            string nomeAluno;
            Console.WriteLine ("Bem vindos a nossa primeira aplication");
            Console.WriteLine ();

            //continua escrevendo na mesma linha
            Console.Write ("Digite seu nome: ");
            // Captura o ddo digitado pelo usuario e salvo na variavel;
            nomeAluno = Console.ReadLine ();
            //Concatenação
            Console.WriteLine (nomeAluno +", digite a sua primeira nota:");
            num3 = int.Parse(Console.ReadLine());

            // Interpolação
            Console.WriteLine($"Sua primeira nota é {num3}");

            Console.WriteLine("Digite sua segunda nota:");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            num5 = int.Parse(Console.ReadLine());

            media = (num3 + num4 + num5) /3;

            Console.WriteLine($"Sua média é: {media} ");
        }
    }
}
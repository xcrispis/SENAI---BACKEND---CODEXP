using System;

namespace Exercicio_Condicional_6
{
    class Program
    {
        static void Main(string[] args)
        {
           int idade;

           Console.WriteLine("Qual sua idade?");
           idade = int.Parse(Console.ReadLine());

           if (idade < 10) {
               Console.WriteLine("É pra todo mundo!");
           } else if (idade >= 10 && idade <= 13) {
                Console.WriteLine("Para todos +10! e pra todo mundo!");
           } else if (idade >13 && idade <= 17) {
 Console.WriteLine("Para teens, para +10 e pra todo mundo!");
           } else if (idade >= 17 && idade < 18) {
                Console.WriteLine("Para pessoas maduras, para teens, para +10 e para todo mundo!");
           } else if (idade >= 18) {
                Console.WriteLine("Adultos apenas, para pessoas madurasa, para teens, para +10 e para todo mundo!");
           }

        }
    }
}

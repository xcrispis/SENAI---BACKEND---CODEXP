using System;

namespace Aula_2 {
    class Program {
        static void Main (string[] args) {
            double n1, n2, n3, media;

            Console.WriteLine ("Digite suas notas: ");
            n1 = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite suas notas: ");
            n2 = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite suas notas: ");
            n3 = double.Parse (Console.ReadLine ());

            media = (n1 + n2 + n3) / 3;

            if (media >= 6) {

                Console.WriteLine ($"Média: {media}   Aluno aprovado");
            } else {
                Console.WriteLine ($"Média: {media}Aluno Reprovado");
            }

        }
    }
}
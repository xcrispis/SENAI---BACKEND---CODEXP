using System;

namespace background_CSHARP {
    class Exerecicio {

        static void Main (string[] args) {
            float valor1;
            float procentagem1;
            Console.WriteLine ("Digite o valor do produto: ");
            valor1  = float.Parse(Console.ReadLine ());

            Console.WriteLine ("DIGITE SUA PORCENTAGEM: ");
            procentagem1 = float.Parse(Console.ReadLine ());
            procentagem1 = procentagem1 / 100;
            float resultado = valor1 - (valor1 * procentagem1) ;

            Console.WriteLine($"O seu novo valor será {resultado}");
        }
    }
}
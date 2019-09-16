using System;

namespace Exercicio_Condicional_1 {
    class Program {
        static void Main (string[] args) {
            double salario;
            double despesa;
            double final;

            Console.WriteLine ("Qual seu salário?");
            salario = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Qual suas despesas?");
            despesa = double.Parse (Console.ReadLine ());

            final = salario - despesa;

            if (final > 0) {
                Console.WriteLine ("Você tem um saldo positivo!");
            }else if (final < 0) {
                Console.WriteLine ("VocÊ tem um saldo negativo :(");
            }

        }
    }
}
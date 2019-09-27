using System;

namespace Exercicio_2 {
    class Program {
        static void Main (string[] args) {
            DiaDaSemana ();
        }

        static void DiaDaSemana () {
            Console.WriteLine (DateTime.Now.DayOfWeek);
        }
    }
}
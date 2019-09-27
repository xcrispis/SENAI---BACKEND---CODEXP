using System;

namespace Exercicio_1 {
    class Program {
        static void Main (string[] args) {
              CalculaValor(0, 0, 0);
        }
           
        static double CalculaValor(double Valor, double Desconto, double Resultado) {
            

            Console.WriteLine ("Digite o seu valor: ");
            Valor = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o seu desconto: ");
            Desconto = double.Parse (Console.ReadLine ());

            Resultado = Valor - ((Desconto/100) * Valor);
            Console.WriteLine($"O seu valor final é: {Resultado}");

            return Resultado;
        }
    }

}
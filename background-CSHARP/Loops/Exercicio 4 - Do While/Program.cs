using System;

namespace Exercicio_4___Do_While
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor = 0;
            
            do
            {
                valor++;
                Console.WriteLine(valor*valor*valor);
            } while (valor < 100);
        }
    }
}

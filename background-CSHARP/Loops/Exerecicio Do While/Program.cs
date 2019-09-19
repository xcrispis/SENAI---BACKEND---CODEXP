using System;

namespace Exerecicio_Do_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            
        int valor = 0;
        int cumulativa = 0;
        int soma = 0;


            do{
            Console.WriteLine("Digite seu numero: ");
            valor = int.Parse(Console.ReadLine());

            if ((valor % 3) == 0 )
            {
            soma = soma + valor;
            }


            cumulativa++;


            } while (cumulativa < 20);


            Console.WriteLine(soma);





        }
    }
}

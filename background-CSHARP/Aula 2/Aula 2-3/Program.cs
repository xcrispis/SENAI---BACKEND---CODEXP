using System;

namespace Aula_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entrada = false;
            int idade;
            string retorno;
            
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

if(idade >17) {
    entrada = true;
}


if( entrada == true) {
    retorno = "Entrada Permitida!";
} else {
    retorno = "Entrada negada!";
}

Console.WriteLine(retorno);

        }
    }
}

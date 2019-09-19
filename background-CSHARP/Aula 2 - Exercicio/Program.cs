using System;

namespace Aula_2___Exercicio {
    class Program {
        static void Main (string[] args) {
            int pedido;
            string texto;

            Console.WriteLine ("Qual numero do seu pedido?");
            pedido = int.Parse (Console.ReadLine ());

           
            switch (pedido) {
                case 1:
                    texto = "hamburguer";
                    break;
                case 2:
                    texto = "xsalada ";
                    break;
                case 3:
                    texto = "xbacon";
                    break;
                case 4:
                    texto = "xburger";
                    break;

                default:
                    texto = "Invalido";
                    break;
            }

            Console.WriteLine (texto);

        }
    }
}
using System;

namespace Aula8___2 {
    class Program {
        static void Main (string[] args) {
            int numero;
            try {
                Console.WriteLine ("Digite um numemro");
                numero = int.Parse (Console.ReadLine ());
            } catch (Exception ex) {

                //  Mostrando a excessão da regra
                //Erro gerado na aplicação
                Console.WriteLine("Foda bê" + ex);
            }
        }
    }
}
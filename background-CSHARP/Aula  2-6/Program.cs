using System;

namespace Aula__2_6 {
    class Program {
        static void Main (string[] args) {
            double peso;
            int planeta;

            Console.WriteLine ("Peso: ");
            peso = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Planeta escolhido: ");
            planeta = int.Parse (Console.ReadLine ());

            switch (planeta) {
                case 1:
                    Console.WriteLine ($"O seu peso em Merccurio é {peso/10 * 0.37} ");
                    break;

                    case 2:
                    Console.WriteLine ($"O seu peso em Vênus é {peso/10 * 0.88} ");
                    break;

                    case 3:
                    Console.WriteLine ($"O seu peso em Marte é {peso/10 * 0.38} ");
                    break;

                    case 4:
                    Console.WriteLine ($"O seu peso em Jupiter é {peso/10 * 2.64} ");
                    break;

                    case 5:
                    Console.WriteLine ($"O seu peso em Saturno é {peso/10 * 1.15} ");
                    break;

                    case 6:
                    Console.WriteLine ($"O seu peso em Urano é {peso/10 * 1.17} ");
                    break;

                    default:
                    Console.WriteLine("Não existe");
                    break;
                    

            }

        }
    }
}
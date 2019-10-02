using System;
using Exercicio_2_2_Aula_11___POO.Models;

namespace Exercicio_2_2_Aula_11___POO.Controller {

    public class CelularController {
        CelularModel cel = new CelularModel ();
        public void Celular () {
            cel.ligado = false;

            if (cel.ligado == false) {
                Console.WriteLine ("Digite F para ligar o celular");
                string F = Console.ReadLine ();
                if (F == "F") {
                    cel.ligado = true;
                    while (cel.ligado == true) {
                        int x = 0;
                        Console.WriteLine ("Se deseja fazer ligação, digite 1, se deseja enviar uma mensagem, digite 2. Para desligar, digite 3.");
                        x = int.Parse (Console.ReadLine ());
                        switch (x) {
                            case 1:
                                Console.WriteLine ("Digite o numero que deseja ligar");
                                Console.ReadLine ();
                                Console.WriteLine ("Chamando... não atendeu :(");
                                break;

                            case 2:
                                Console.WriteLine ("Digite o numero que deseja enviar mensagem");
                                Console.ReadLine ();
                                Console.WriteLine ("Digite sua mensagem");
                                Console.ReadLine ();
                                Console.WriteLine ("Mensagem enviada!");
                                break;

                            case 3:
                                Console.WriteLine ("Desligando...");
                                cel.ligado = false;
                                break;
                        }
                    }

                }
            }

        }
    }
}
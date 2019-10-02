using System;
using PROJETO_VINGADORES.Model;
namespace PROJETO_VINGADORES.Controller {
    public class VingadoresController {
        public void JogoVingadores () {

            string jogar = "sim";
            int Botao = 0;

            while (jogar == "sim") {
                System.Console.WriteLine ("BEM VINDO AO JOGO DOS VINGADORES!");
                System.Console.WriteLine ("DESEJA JOGAR? Digite sim ou nao");
                jogar = Console.ReadLine ();
                if (jogar == "sim") {
                    System.Console.WriteLine ("COM QUEM DESEJA JOGAR?");
                    System.Console.WriteLine ("DIGITE 1: CAPITÃO AMERICA \nDIGITE 2: HOMEM DE FERRO");
                    int equipe = int.Parse (Console.ReadLine ());

                    if (equipe == 1) {
                        CapitaoAmerica Cap = new CapitaoAmerica ();
                        Cap.vida = 1000;
                        System.Console.WriteLine ("Você escolheu o Capitão América!");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine ("Qual o tipo do seu escudo?");
                        Cap.escudo = Console.ReadLine ();

                        while (Botao != 4) {
                            System.Console.WriteLine ($"AÇÕES \n 1 - PULAR \n 2 - LANÇAR ESCUDO DE {Cap.escudo} \n 3 - DEFENDER-SE COM ESCUDO DE {Cap.escudo} \n 4 - VOLTAR A TELA INICIAL");
                            Botao = int.Parse (Console.ReadLine ());

                            switch (Botao) {
                                case 1:
                                    System.Console.WriteLine ("Você saltou! Que incrivel!");
                                    break;

                                case 2:
                                    System.Console.WriteLine ($"Você lança seu escudo de {Cap.escudo}, e acerta em cheio! Você matou um inocente!");
                                    break;

                                case 3:
                                    System.Console.WriteLine ($"Você utilizou seu escudo para bloquear a chinela da sua mãe, mandou bem!");
                                    break;

                                case 4:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                default:
                                    System.Console.WriteLine ("Essa opção não é valida!");
                                    break;
                            }
                        }

                    } else if (equipe == 2) {
                        HomemDeFerro Ferr = new HomemDeFerro ();
                        Ferr.vida = 1000;
                        System.Console.WriteLine ("Você escolheu o Homem de ferro!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine ("Qual o modelo da sua armadura?");
                        Ferr.armadura = Console.ReadLine ();

                        while (Botao != 4) {
                            System.Console.WriteLine ($"AÇÕES \n 1 - PULAR \n 2 - VOCÊ ESTÁ VOANDO COM A {Ferr.armadura} \n 3 - VOCÊ ATIOU COM SEU LAZER E ACERTOU NA MOSCA! \n 4 - VOLTAR A TELA INICIAL");
                            Botao = int.Parse (Console.ReadLine ());

                            switch (Botao) {
                                case 1:
                                    System.Console.WriteLine ("Você saltou! Que incrivel!");
                                    break;

                                case 2:
                                    System.Console.WriteLine ($"Você está voando!");
                                    break;

                                case 3:
                                    System.Console.WriteLine ($"Você utilizou seu laser! Oh não, ele se descontrolou e você matou um inocente por acidente!!");
                                    break;

                                case 4:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                default:
                                    System.Console.WriteLine ("Essa opção não é valida!");
                                    break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine ("Jogo Encerrado.");

        }
    }
}
using System;
using Exercicio_2_1_Aula_11___POO.Models;
namespace Exercicio_2_1_Aula_11___POO.Controller {
    public class AlunoController {
        AlunoModel dados = new AlunoModel ();

        public void MostraAluno () {

            Console.WriteLine ("Digite seu nome: ");
            dados.nome = Console.ReadLine ();
            Console.WriteLine ("Digite seu curso: ");
            dados.curso = Console.ReadLine ();
            Console.WriteLine ("Digite seu RG: ");
            dados.rg = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite sua idade: ");
            dados.idade = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Você é bolsista? Se sim, digite true, se não, digite false.");
            dados.bolsista = bool.Parse (Console.ReadLine ());
            string borsa = "";
            if (dados.bolsista == true) {
                borsa = "Você é bolsista!";
            } else {
                borsa = "Você não é bolsista!";
            }

            Console.WriteLine ($"Olá {dados.nome}, vocÊ cursa {dados.curso} e seu RG é {dados.rg}, sua idade é {dados.idade}. {borsa}");

        }
    }
}
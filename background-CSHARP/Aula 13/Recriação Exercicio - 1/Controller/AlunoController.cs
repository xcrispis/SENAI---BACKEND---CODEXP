using System.Collections.Generic;
using Recriação_Exercicio___1.Model;
using System;

namespace Recriação_Exercicio___1.Controller {
    public class AlunoController {

        public void Aluno () {
            AlunoModel mod = new AlunoModel ("A", "B", 2, 3, false);
            string sn = "sim";
            List<AlunoModel> prod = new List<AlunoModel> ();
            while (sn == "sim") {

                Console.WriteLine ("Digite seu nome: ");
                mod.nome = Console.ReadLine ();
                Console.WriteLine ("Digite seu curso: ");
                mod.curso = Console.ReadLine ();
                Console.WriteLine ("Digite seu RG: ");
                mod.rg = int.Parse (Console.ReadLine ());
                Console.WriteLine ("Digite sua idade: ");
                mod.idade = int.Parse (Console.ReadLine ());
                Console.WriteLine ("Você é bolsista? Se sim, digite true, se não, digite false.");
                mod.bolsista = bool.Parse (Console.ReadLine ());

                prod.Add (new AlunoModel (mod.nome, mod.curso, mod.rg, mod.idade, mod.bolsista));

                Console.WriteLine ("Deseja cadastrar um novo aluno? sim ou não");
                sn = Console.ReadLine ();
            }

            foreach (AlunoModel p in prod) {
                Console.WriteLine ("");
                Console.WriteLine (p.nome);
                Console.WriteLine (p.curso);
                Console.WriteLine (p.rg);
                Console.WriteLine (p.idade);
                Console.WriteLine (p.bolsista);
                Console.WriteLine ("");
            }

        }

    }
}
using System;
using Exercicio_Aula_11___POO.Models;
namespace Exercicio_Aula_11___POO.Controller {
    public class ImcController {
        ImcModel calculo = new ImcModel ();

        public void CalculaImc () {
            Console.WriteLine ("Digite sua idade: ");
            calculo.Idade = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite seu nome: ");
            calculo.Nome = Console.ReadLine ();
            Console.WriteLine ("Digite seu peso: ");
            calculo.Peso = double.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite sua altura: ");
            calculo.Altura = double.Parse (Console.ReadLine ());


            calculo.Imc = calculo.Peso / (calculo.Altura * calculo.Altura);
            Console.WriteLine($"Olá {calculo.Nome}, você possui {calculo.Idade} anos, tem {calculo.Peso}KG, e sua altura é:{calculo.Altura}. ");

            if (calculo.Imc < 18.5) {
                 Console.WriteLine ("Peso abaixo do normal");
            } else if ((calculo.Imc == 18.5) || (calculo.Imc == 25)) {
                Console.WriteLine ("Peso normal");
            }
            if ((calculo.Imc > 25) || (calculo.Imc == 30))
            {
                Console.WriteLine ("Sobre o Peso");
            } else if ((calculo.Imc > 30) || (calculo.Imc == 35)) {
                Console.WriteLine ("Grau de Obesidade I");
            }
            if ((calculo.Imc > 35) || (calculo.Imc == 40)) {
                Console.WriteLine ("Grau de Obesidade II");
            } else if (calculo.Imc > 40) {
                Console.WriteLine ("Obesidade Grau III");
            }
        }

    }
}
using System;
using Aula_12.Model;
namespace Aula_12.Controller {
    public class CarroController {
        CarroModels carro = new CarroModels ();

        MotorModels Motor = new MotorModels ();

        public void Ligar () {
            carro.Ligado = true;
            Console.WriteLine ("Ligando carro!");
        }

        public void Desligar () {
            carro.Ligado = false;
            Console.WriteLine ("Desligando carro...");
        }

        public void Acelerar () {
            if (carro.Ligado == true) {
                System.Console.WriteLine ("Carro acelerando!");
            } else {
                System.Console.WriteLine ("O carro não está ligiado! Impossivel acelerar");
            }
        }

        public void Freiar () {
            if (carro.Ligado == true) {
                System.Console.WriteLine ("Carro freiando");
            } else {
                System.Console.WriteLine("O carro não está ligado! No da para frear senõr!");
            }
        }

        public void CadastrarMotor(){
            System.Console.WriteLine("Insina quantos cavalos tem o motor: ");
            Motor.Cavalos = int.Parse(Console.ReadLine());
           
            System.Console.WriteLine("Insina quantos cilindros tem o motor: ");
            Motor.Cilindros = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Insina o modelo do pistão do carro: ");
            Motor.Pistao = int.Parse(Console.ReadLine());


        }
    }
}
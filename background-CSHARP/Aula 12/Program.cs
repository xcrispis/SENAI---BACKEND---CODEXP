using System;
using Aula_12.Controller;
using Aula_12.Model;

namespace Aula_12 {
    class Program {
        static void Main (string[] args) {
            CarroController carro = new CarroController ();
            CarroEletricoModel carroEletrico = new CarroEletricoModel ();
            Console.Clear ();

            carroEletrico.Ligar ();
            carroEletrico.CarregarBateria(100);
            carroEletrico.CarregarBateria(15);
            System.Console.WriteLine("Carga do carro em: ");
            carroEletrico.StatusBateria());
            carro.CadastrarMotor ();
        }
    }
}
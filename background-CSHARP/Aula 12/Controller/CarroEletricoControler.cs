using Aula_12.Model;

namespace Aula_12.Controller
{
    public class CarroEletricoControler : CarroController
    {
        CarroEletricoModel carroEletrico = new CarroEletricoModel();

        MotorModels motor = new MotorModels();

        public void CarregarBateria(float carga) {
            if (carroEletrico.Bateria < 100)
            {
                carroEletrico.Bateria += carga;
            } else {
                System.Console.WriteLine("A bateria do carro já está completa! Pode viajar!");
            }
        }

        public float StatusBateria()
        {
            return carroEletrico.Bateria;
        }
    }
}
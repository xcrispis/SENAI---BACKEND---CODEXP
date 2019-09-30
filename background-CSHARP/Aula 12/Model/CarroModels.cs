namespace Aula_12.Model {
    public class CarroModels {
        public string Marca { get; set;}
        public string Modelo { get; set;}
        public string Cor { get; set; }
        public string Placa { get; set; }
        public bool Ligado { get; set; }
        public MotorModels Motor {get; set;}
    }
}
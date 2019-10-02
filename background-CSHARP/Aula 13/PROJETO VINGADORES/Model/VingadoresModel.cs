namespace PROJETO_VINGADORES.Model {
    public class VingadoresModel {
        public double vida { get; set; }
        public double cor { get; set; }
        public double equipe { get; set; }

    }
    public class CapitaoAmerica : VingadoresModel {
        public string escudo { get; set; }
    }

    public class HomemDeFerro : VingadoresModel {
        public string armadura { get; set; }
    }

}
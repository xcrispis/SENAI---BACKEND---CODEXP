namespace Recriação_Exercicio___1.Model {
    public class AlunoModel {
        public string nome { get; set; }
        public string curso { get; set; }
        public int rg { get; set; }
        public int idade { get; set; }
        public bool bolsista { get; set; }

        public AlunoModel (string Nome, string Curso, int Rg, int Idade, bool Bolsista){
            this.nome = Nome;
            this.curso = Curso;
            this.rg  = Rg;
            this.idade = Idade;
            this.bolsista = Bolsista;
        }

        public AlunoModel()
        {
        }
    }
}
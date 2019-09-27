using System;
namespace Senai_Aluno.Models

{
    public class AlunoModel {
        /// <summary>
        /// Nome do aluno
        /// </summary>
        /// <value></value>
        public string nome { get; set; }
        /// <summary>
        /// Curso do aluno
        /// </summary>
        /// <value></value>
        public string curso { get; set; }
        /// <summary>
        /// RA DO aluno
        /// </summary>
        /// <value></value>
        public string RA { get; set; }
        /// <summary>
        /// Idade do aluno
        /// </summary>
        /// <value></value>
        public int idade { get; set; }


        public void Estudar(){
            Console.WriteLine("Estou estudando!");
        }

        public void PedirAjuda(){
            Console.WriteLine("Estou pedindo ajuda!");
        }

        public void PedirIntervalo(){
            Console.WriteLine("CadÊ o intervalo??");
        }



    }
}
using System;

namespace Funções {
    class Program {
        static void Main (string[] args) {
            BomDia ();
            //Função do tipo void sem retorno
            ImprimeDataHora ();
            double[] numeros = { 2, 5, 2 };

            Console.WriteLine (CalculaMedia (numeros));

            Console.WriteLine(CalculaSoma(numeros));
        }

        /// <summary>
        /// Função que escreve bom dia para o usuario
        /// </summary>
        /// <returns></returns>

        static string BomDia () {
            return "Olá! Bom Dia!";
        }

        static string BomDia (string saudacao) {
            int hora = DateTime.Now.Hour;

            if (hora <= 12 && hora >= 6) {
                saudacao = "Bom Dia";
            } else if (hora >= 12 && hora <= 18) {
                saudacao = "Boa Tarde";
            } else {
                saudacao = "Boa Noite";
            }
            return saudacao;
        }

        /// <summary>
        /// Retorna data e hora atual
        /// </summary>
        static void ImprimeDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.Hour.ToString ());
        }

        /// <summary>
        /// FUNÇAO QUE CALCULA A MÉDIA DE UM VETOR
        /// </summary>
        /// <param name="valores">Vetor com Valores</param>
        /// <returns>Média dos Valores</returns>
        static double CalculaMedia (double[] valores) {
            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado += valores[i];
            }

            resultado = resultado / valores.Length;

            return resultado;
        }

        static double CalculaSoma (double[] valores) {
            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado += valores[i];
            }

            return resultado;
        }

    }
}

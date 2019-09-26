using System;

namespace Função_Checa_CNPJ {
    class Program {
        static void Main (string[] args) {
            string cnpj;
            Console.WriteLine ("Qual seu CNPJ?");
            cnpj = Console.ReadLine ();

        }

        static string cnpjCalculo (string cnpj) {
            bool resultado = false;
            int[] PesoDosValores = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] PesoDosValores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int ValorSomaCalculo = 0;
            int ValorSomaCalculo2 = 0;
            string v1 = "";
            string v2 = "";
            int verificador;

            for (int i = 0; i < 12; i++) {
                ValorSomaCalculo += PesoDosValores[i] * int.Parse (cnpj[i].ToString ());
            }

            v1 = ValorSomaCalculo % 11;

            if (v1 > 9) {
                verificador = 0;
            } else {
                verificador = 11 - v1;
            }

            for (int i = 0; i < 13; i++) {
                ValorSomaCalculo2 = +PesoDosValores2[i] * int.Parse (cnpj[i].ToString ());
            }

            ValorSomaCalculo2 = ValorSomaCalculo2 % 11;

            if (ValorSomaCalculo2 < 2) {
                v2 = "0";
            } else {
                ValorSomaCalculo2 = 11 - ValorSomaCalculo2;
            }

            if (v2 == cnpj[13].ToString ()) {

            }

            return resultado;
        }
    }
}
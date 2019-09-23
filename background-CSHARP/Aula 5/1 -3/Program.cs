using System;

namespace _1__3 {
    class Program {
        static void Main (string[] args) {
            string[] nome1 = new string[12];
            string[] cor1 = new string[12];
            int[] tamanho1 = new int[12];
            double[] preço1 = new double[12];

            for (int i = 0; i < 12; i++) {
                Console.WriteLine ("Nome do produto: ");
                nome1[i] = Console.ReadLine();

                Console.WriteLine ("Cor do produto: ");
                cor1[i] = Console.ReadLine();

                Console.WriteLine ("Tamanho do produto: ");
                tamanho1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine ("Preço do produto: ");
                preço1[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"\n Nome do Produto: {nome1[i]}\n Cor: {cor1[i]}\n Tamanho : {tamanho1[i]}\n Preço: {preço1[i]} \n");
            }
        }
    }
}
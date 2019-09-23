using System;

namespace Exercicio_4___6
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero1 = 0, numero2 = 1, numero3, i, numero;   

         Console.Write("Quantos elementos da sequência você quer?");    
         numero = int.Parse(Console.ReadLine());  
         
         Console.Write(numero1+" "+numero2+" "); 

         for(i=2; i < numero; ++i)    
         {    
          numero3=numero1+numero2;    
          Console.Write(numero3+" ");    
          numero1=numero2;    
          numero2=numero3;    
         }    
        }
    }
}

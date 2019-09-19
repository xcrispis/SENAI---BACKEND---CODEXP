using System;

namespace Exercicio_4___6
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1=0,n2=1,n3,i,numero;    
         Console.Write("Quantos elementos da sequência você quer? ");    
         numero = int.Parse(Console.ReadLine());  
         Console.Write(n1+" "+n2+" "); 
         for(i=2; i < numero; ++i)    
         {    
          n3=n1+n2;    
          Console.Write(n3+" ");    
          n1=n2;    
          n2=n3;    
         }    
        }
    }
}

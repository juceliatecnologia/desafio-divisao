using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numerador:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o denominador:");
            double y = Double.Parse(Console.ReadLine());
         
            Divisao(x,y);
           
        }

        private static void Divisao(double n1, double n2)

        {
            
            
             if (n2 == 0) 
                {
                Console.WriteLine("Divisão impossível");
                }
                else 
                {
                    double result = n1/n2; 
                    Console.WriteLine($"O resultado da divisão é: " +  result.ToString("N1"));
                }
        }
    }
 
}
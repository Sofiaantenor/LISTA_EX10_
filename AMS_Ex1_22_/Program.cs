using System;

namespace AMS_Ex1_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeMinima;
            int idadeMaxima;

            Console.WriteLine("");
            Console.WriteLine("          ***CÁLCULO DE MÉDIA ENTRE DUAS IDADES***      ");

            Console.Write("Digite a idade máxima: ");
            idadeMaxima = Convert.ToInt16(Console.ReadLine()); 

            Console.Write("Digite a idade mínima: ");
            idadeMinima = Convert.ToInt16(Console.ReadLine()); 

            int mediaIdade = (idadeMinima + idadeMaxima)/2;
            
            Console.WriteLine($"A média dessas idades é: {mediaIdade}");
            Console.WriteLine("");
        }
    }
}

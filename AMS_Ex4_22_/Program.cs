using System;

namespace AMS_Ex4_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            double grausCelsius;

            Console.WriteLine("");
            Console.WriteLine("    ***CONVERSÃO DE GRAUS CELSIUS PARA FAHRENHEIT***      ");

            Console.Write("Digite o valor em graus Celsius que deseja converter para Fahrenheit: ");
            grausCelsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (9 * grausCelsius + 160) / 5;

            Console.WriteLine($"O valor equivalente a {grausCelsius} graus Celsius em Fahrenheit é {fahrenheit}");
            Console.WriteLine("");
        }
    }
}

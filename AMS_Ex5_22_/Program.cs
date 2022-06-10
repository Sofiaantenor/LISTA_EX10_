using System;

namespace AMS_Ex5_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;

            Console.WriteLine("");
            Console.WriteLine("    ***CONVERSÃO DE FAHRENHEIT PARA GRAUS CELSIUS***      ");

            Console.Write("Digite o valor em graus Fahrenheit que deseja converter para graus Celsius: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            double grausCelsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"O valor equivalente a {fahrenheit} graus fahrenheit em graus Celsius é {grausCelsius}");
            Console.WriteLine("");
        }
    }
}

using System;

namespace AMS_Ex6_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;

            Console.WriteLine("");
            Console.WriteLine("         ***CÁLCULO DO PESO IDEAL DE UM HOMEM***      ");

            Console.Write("Digite a sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            double pesoIdeal = (72.7 * altura) - 58;

            Console.WriteLine($"O peso ideal desse homem de acordo com a sua altura é {pesoIdeal} Kg");
            Console.WriteLine("");
        }
    }
}

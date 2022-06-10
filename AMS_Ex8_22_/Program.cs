using System;

namespace AMS_Ex8_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;

            Console.WriteLine("");
            Console.WriteLine("         ***CÁLCULO DE SUBTRAÇÃO ENTRE DOIS VALORES***      ");

            Console.Write("Digite o primeiro valor: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToDouble(Console.ReadLine());

            double resultado = v1 - v2;

            if( resultado < 0)
            {
               Console.WriteLine($"O resultado dessa subtração é negativo! O número resultante é: {resultado}");
            }
            else if(resultado > 0)
            {
               Console.WriteLine($"O resultado dessa subtração é positivo! O número resultante é: {resultado}");
            }
            else 
            {
               Console.WriteLine("O resultado dessa subtração é zero!");
            }

            Console.WriteLine("");

        }
    }
}

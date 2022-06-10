using System;

namespace AMS_Ex9_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            
            Console.WriteLine("");
            Console.WriteLine("        ***CÁLCULO DO RESTO DE UMA DIVISÃO ENTRE DOIS VALORES***      ");

            Console.Write("Digite o primeiro valor: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToDouble(Console.ReadLine());
            
            double resto = v1 % v2;

            if (v2 == 0)
            {
               Console.WriteLine("Não é possível realizar uma divisão por 0!");
            }
            else
            {
               Console.WriteLine($"O resto da divisão entre {v1} e {v2} é {resto}");
            }

            Console.WriteLine("");
        }
    }
}

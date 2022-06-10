using System;

namespace AMS_Ex2_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            double euro;
            double qtdEuro;
            
            Console.WriteLine("");
            Console.WriteLine("     ***CONVERÇÃO DE EUROS PARA O REAL BRASILEIRO***      ");

            Console.Write("Digite o atual valor do euro: ");
            euro = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor em euro que deseja converter: ");
            qtdEuro = Convert.ToDouble(Console.ReadLine()); 

            double real = (qtdEuro * euro);

            Console.WriteLine($"O valor dessa quantia em euro convertida para o real é de: {real} reais");
            Console.WriteLine("");
        }
    }
}

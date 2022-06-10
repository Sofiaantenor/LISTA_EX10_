using System;

namespace AMS_Ex3_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorVendido;
            int porcentagem;

            Console.WriteLine("");
            Console.WriteLine("          ***CÁLCULO DE COMISSÃO DE VENDAS***      ");

            Console.Write("Digite o valor que foi vendido: ");
            valorVendido = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Digite o número da porcentagem da comissão do funcionário: ");
            porcentagem = Convert.ToInt32(Console.ReadLine()); 

            int resultado = valorVendido * porcentagem /100;

            Console.WriteLine("");
            Console.WriteLine($"O valor da comissão desse vendedor será de: {resultado}");
            Console.WriteLine("");
        }
    }
}

using System;

namespace AMS_Ex7_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double nota4;

            Console.WriteLine("");
            Console.WriteLine("         ***CÁLCULO DA MÉDIA DE UM ALUNO***      ");

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

             double media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("");

            Console.WriteLine($"A média desse aluno é {media}");
            Console.WriteLine("");

            if (media > 7 )
            {
               Console.WriteLine("                  ALUNO APROVADO!");
            } 
            else
            {
               Console.WriteLine("                  ALUNO REPROVADO!");
            }

            Console.WriteLine("");
        }
    }
}

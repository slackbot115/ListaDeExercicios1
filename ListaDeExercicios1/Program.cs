using System;

namespace Lista1Exerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a imobiliaria Imobilis!");
            Console.WriteLine("Digite o valor de um dos lados: ");
            double l1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do comprimento: ");
            double l2 = double.Parse(Console.ReadLine());
            double area = l1 * l2;
            Console.WriteLine("O valor da area deste terreno é: " + area);
        }
    }
}

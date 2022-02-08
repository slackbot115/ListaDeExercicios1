using System;

namespace Lista1Exerc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Corretor de salário");
            Console.WriteLine("Digite o seu salario: ");
            double salario = double.Parse(Console.ReadLine());
            double salario_aumento = salario + (salario * 0.15);
            double salario_imposto = salario_aumento - (salario_aumento * 0.08);
            Console.WriteLine("Salario inicial: " + salario);
            Console.WriteLine("Salario com aumento: " + salario_aumento);
            Console.WriteLine("Salario final: " + salario_imposto);
        }
    }
}

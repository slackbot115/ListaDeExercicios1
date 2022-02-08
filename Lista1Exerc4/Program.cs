using System;

namespace Lista1Exerc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Temperatura");
            while (true)
            {
                Console.WriteLine("\nDigite a opção desejada: ");
                Console.WriteLine("1 - Celsius para Fahrenheit\n" +
                    "2 - Fahrenheit para Celsius\n" +
                    "3 - Celsius para Kelvin\n" +
                    "4 - Kelvin para Celsius\n" +
                    "5 - Fahrenheit para Kelvin\n" +
                    "6 - Kelvin para Fahrenheit\n" +
                    "0 - Para sair");
                int op = int.Parse(Console.ReadLine());
                if (op == 0)
                {
                    Console.WriteLine("Saindo do programa...");
                    break;
                }
                else if (op == 1)
                {
                    Console.Write("Digite o valor em Celsius: ");
                    double c = double.Parse(Console.ReadLine());
                    double f = c * 1.8 + 32;
                    Console.WriteLine("O valor " + c + "ºC é " + f + "ºF");
                }
                else if (op == 2)
                {
                    Console.Write("Digite o valor em Fahrenheit: ");
                    double f = double.Parse(Console.ReadLine());
                    double c = (f - 32) * 1.8;
                    Console.WriteLine("O valor " + f + "ºF é " + c + "ºC");
                }
                else if (op == 3)
                {
                    Console.WriteLine("Digite o valor em Celsius: ");
                    double c = double.Parse(Console.ReadLine());
                    double k = c + 273.15;
                    Console.WriteLine("O valor " + c + "ºC é " + k + "ºK");
                }
                else if (op == 4)
                {
                    Console.WriteLine("Digite o valor em Kelvin: ");
                    double k = double.Parse(Console.ReadLine());
                    double c = k - 273.15;
                    Console.WriteLine("O valor " + k + "ºK é " + c + "ºC");
                }
                else if (op == 5)
                {
                    Console.Write("Digite o valor em Fahrenheit: ");
                    double f = double.Parse(Console.ReadLine());
                    double k = (f - 32) * 1.8 + 273.15;
                    Console.WriteLine("O valor " + f + "ºF é " + k + "ºK");
                }
                else if (op == 6)
                {
                    Console.WriteLine("Digite o valor em Kelvin: ");
                    double k = double.Parse(Console.ReadLine());
                    double f = (k - 273.15) * 1.8 + 32;
                    Console.WriteLine("O valor " + k + "ºK é " + f + "ºF");
                }
            }
        }
    }
}

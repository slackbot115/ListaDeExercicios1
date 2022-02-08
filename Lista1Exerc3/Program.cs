using System;

namespace Lista1Exerc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador de dias vividos!");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite quantos anos você tem: ");
            int idade = int.Parse(Console.ReadLine());
            int dias_vividos = idade * 365;
            Console.WriteLine(nome + ", você já viveu " + dias_vividos + " dias!");
        }
    }
}

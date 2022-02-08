using System;

namespace Lista1Exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Controle de ganhos (Hotpão)");
            Console.Write("Digite a quantidade de pães vendidos: ");
            int paes = int.Parse(Console.ReadLine());
            double val_paes = paes * 0.12;
            Console.Write("Digite a quantidade de broas vendidos: ");
            int broas = int.Parse(Console.ReadLine());
            double val_broas = broas * 1.5;
            double val_total = val_paes + val_broas;
            Console.WriteLine("O valor total das vendas do dia é: " + val_total);
            double val_poupanca = val_total * 0.10;
            Console.WriteLine("Valor para depositar na poupança: " + val_poupanca);
        }
    }
}

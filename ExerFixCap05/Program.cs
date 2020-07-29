using System;
using System.Globalization;

namespace ExerFixCap05
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito;
            Conta conbancaria;

            Console.Write("Entre com o núemro de conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial (S/N): ");
            string sn = Console.ReadLine();

            if (sn == "S" || sn == "s")
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conbancaria = new Conta(conta, nome, deposito);
            }
            else {
                conbancaria = new Conta(conta, nome);
            }

            Console.WriteLine($"\nDados da cona: " + conbancaria);

            Console.Write("\nEntre com um valr para deposito: ");
            double vldeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conbancaria.VlDeposito(vldeposito);

            Console.WriteLine($"Dados atualizados: " + conbancaria);

            Console.Write("\nEntre com um valor para saque: ");
            double vlsaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conbancaria.Vlsaque(vlsaque);

            Console.WriteLine($"Dados atualizados: " + conbancaria);
        }
    }
}

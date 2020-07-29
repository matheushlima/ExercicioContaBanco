using System;
using System.Globalization;

namespace ExerFixCap05
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string Nome { get; private set; }
        public double Deposito { get; private set; }

        

        public Conta(int conta, string nome)
        {
            NumConta = conta;
            Nome = nome;
        }

        public Conta(int conta, string nome , double deposito)
        {
            NumConta = conta;
            Nome = nome;
            Deposito = deposito;
        }

        public void VlDeposito(double deposito)
        {
            Deposito += deposito;
        }

        public void Vlsaque(double saque)
        {
            Deposito = Deposito - (saque + 5);
        }

        public override string ToString()
        {
            return $"Conta {NumConta}, Titular: {Nome}, Saldo: $ {Deposito.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

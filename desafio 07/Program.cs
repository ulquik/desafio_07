using System;

namespace desafio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta();

            minhaConta.titular = "Rodrigo";
            minhaConta.numero = 123456789;
            minhaConta.saldo = 350;

            minhaConta.SacarValor(65);
            minhaConta.DepositarValor(98);

            Console.WriteLine($"{minhaConta.titular} conta {minhaConta.numero} possui um saldo de: {minhaConta.saldo} reais");
            
        }
    }
}

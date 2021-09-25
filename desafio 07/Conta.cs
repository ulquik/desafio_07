using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_07
{
    class Conta
    {
        public String titular;
        public int numero;
        public double saldo;


        internal void SacarValor(double quantidade)
        {
            double novoSaldo = this.saldo - quantidade;
            this.saldo = novoSaldo;
        }

        internal void DepositarValor(double quantidade)
        {
            this.saldo += quantidade;
        }
    }

}



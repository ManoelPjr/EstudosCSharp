using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio1
{
    class ContaCorrente
    {

        private string _titular;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        private ContaCorrente()
        {
            Saldo = 0.0;
        }

        public ContaCorrente(string titular, int numero) : this()
        {
            _titular = titular;
            Numero = numero;
        }

        public ContaCorrente(string titular, int numero, double depositoInicial) : this(titular, numero)
        {
             Deposito(depositoInicial);
        }

        public string Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                string NomeLimpo = value.Trim();
                if (NomeLimpo != null && NomeLimpo.Length > 1)
                {
                    _titular = NomeLimpo;
                }
            }
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5.00);
        }

        public override string ToString()
        {
            return "Conta " + Numero.ToString()
                + ", Titular: " + _titular
                + ", Saldo $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

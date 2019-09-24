using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente;

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N)?: ");
            char temDdepositoInicial = char.Parse(Console.ReadLine());

            if (temDdepositoInicial == 'S' || temDdepositoInicial == 's')
            {

                Console.Write("Entre com o valor do depósito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaCorrente = new ContaCorrente(titular, numeroConta, valorDepositoInicial);

            }
            else
            {
                contaCorrente = new ContaCorrente(titular, numeroConta);
            }

            Console.Write("Dados da conta:");
            Console.WriteLine(contaCorrente);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            contaCorrente.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write("Dados da conta atualizados: ");
            Console.Write(contaCorrente);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            contaCorrente.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write("Dados da conta atualizados: ");
            Console.Write(contaCorrente);

        }
    }
}

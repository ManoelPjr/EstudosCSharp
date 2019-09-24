using System;
using Sobreposicao.Entities;

namespace Sobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
            Account acc3 = new BusinessAccount(1003, "Manoel", 500.0, 1000.0);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            acc3.Withdraw(10.0);

            Console.WriteLine("Account: "+acc1.Balance);
            Console.WriteLine("SavingsAccount: "+acc2.Balance);
            Console.WriteLine("BusinessAccount: "+acc3.Balance);
        }
    }
}

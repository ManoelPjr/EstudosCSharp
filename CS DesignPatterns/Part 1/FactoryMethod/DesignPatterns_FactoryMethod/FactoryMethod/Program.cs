using System;

namespace FactoryMethod
{
    class Program
    {

        static void Main(string[] args)
        {
            var factory = new SavingsAcctFactory() as ICreditUnionFactory;
            var citiAcct = factory.GetSavingsAccount("CITI-321");
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");

            Console.WriteLine($"My citi balance is ${citiAcct.Balance}" +
                $" and national balance is ${nationalAcct.Balance}");
        }

        // Product
        public abstract class ISavingsAccount
        {
            public decimal Balance { get; set; }
        }

        // Concrete Product
        public class CitiSavingsAcct : ISavingsAccount
        {
            public CitiSavingsAcct()
            {
                Balance = 5000;
            }
        }
        // Concrete Product
        public class NationalSavingsAcct : ISavingsAccount
        {
            public NationalSavingsAcct()
            {
                Balance = 2000;
            }
        }
        // Creator
        interface ICreditUnionFactory
        {
            ISavingsAccount GetSavingsAccount(string accNo);
        }
        // Concrete Creators
        public class SavingsAcctFactory : ICreditUnionFactory
        {
            public ISavingsAccount GetSavingsAccount(string accNo)
            {
                if (accNo.Contains("CITI")) { return new CitiSavingsAcct(); }
                else
                if (accNo.Contains("NATIONAL")) { return new NationalSavingsAcct(); }
                else
                    throw new ArgumentException("Invalid Account Number");

            }
        }

    }
}

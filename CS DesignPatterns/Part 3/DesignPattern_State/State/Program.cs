using State.Classes;
using System;
/// <summary>
/// This code demonstrates the State pattern which allows an Account
/// to behave differently depending on its balance. The difference in 
/// behavior is delegated to State objects called OverdrawnState, 
/// StandardState and PremiumState. These states represent overdrawn 
/// accounts, starter accounts, and accounts in good standing.
/// </summary>
namespace State
{
    /// <summary>
    /// State Design Pattern.
    /// </summary>
    class client
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Open a new account
            Account account = new Account("Reynald Adolphe");

            // Apply transacitons
            account.Deposit(490.0);
            account.Deposit(390.0);
            account.Deposit(540.0);
            account.PayInterest();
            account.Withdraw(2200.0);
            account.Withdraw(1300.0);

            // Wait
            Console.ReadKey();

        }
    }   
}

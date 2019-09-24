using Facade.SubSystem;
using System;

namespace Facade.Classes
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    class CollegeLoan
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Student stud, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
              stud.Name, amount);

            bool eligible = true;

            // Verify creditworthyness of applicant
            if (!_bank.HasSufficientSavings(stud, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(stud))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(stud))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}

using Facade.Classes;
using System;

namespace Facade.SubSystem
{
    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
    class Loan
    {
        public bool HasNoBadLoans(Student c)
        {
            Console.WriteLine("Verify loans for " + c.Name);
            return true;
        }
    }
}

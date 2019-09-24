using Facade.Classes;
using System;

namespace Facade.SubSystem
{
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    class Bank
    {
        public bool HasSufficientSavings(Student c, int amount)
        {
            Console.WriteLine("Verify bank for " + c.Name);
            if (amount < 50000)
            {
                return false;
            }
            return true;
        }
    }
}

using Facade.Classes;
using System;

namespace Facade.SubSystem
{
    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    class Credit
    {
        public bool HasGoodCredit(Student c)
        {
            Console.WriteLine("Verify credit for " + c.Name);
            return true;
        }
    }
}

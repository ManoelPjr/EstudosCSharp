using Facade.Classes;
using System;
/// <summary>
/// This code demonstrates the Facade pattern as a MortgageApplication 
/// object which provides a simplified interface to a large subsystem 
/// of classes measuring the creditworthyness of an applicant.
/// </summary>
namespace Facade
{
    /// <summary>
    /// Facade Design Pattern.
    /// </summary>
    class Client
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Facade
            CollegeLoan collegeLoan = new CollegeLoan();

            // Evaluate loan
            Student student1 = new Student("Hunter Sky");
            Student student2 = new Student("Chico Tripa");
            bool eligible = collegeLoan.IsEligible(student1, 75000);//Acepted
            
            Console.WriteLine("\n" + student1.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

            eligible = collegeLoan.IsEligible(student2, 49900);//Rejected
            Console.WriteLine("\n" + student2.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));
            // Wait for user
            Console.ReadKey();
        }
    }
}

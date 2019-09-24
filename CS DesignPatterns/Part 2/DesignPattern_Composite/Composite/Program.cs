using Composite.Composite;
using Composite.Leaf;
using System;
/// <summary>
/// This code demonstrates the composite pattern for an application where 
/// any employee can see their own performance record. The supervisor can 
/// see their own and their subordinate’s performance record
/// </summary>
namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ricky = new Employee
            { EmployeeID = 1, Name = "ricky", Rating = 3 };
            Employee mike = new Employee
            { EmployeeID = 2, Name = "mike", Rating = 4 };
            Employee maryann = new Employee
            { EmployeeID = 3, Name = "maryann", Rating = 5 };
            Employee ginger = new Employee
            { EmployeeID = 4, Name = "ginger", Rating = 3 };
            Employee olive = new Employee
            { EmployeeID = 5, Name = "olive", Rating = 4 };
            Employee candy = new Employee
            { EmployeeID = 6, Name = "candy", Rating = 5 };

            Supervisor ronny = new Supervisor
            {
                EmployeeID = 7,
                Name = "ronny",
                Rating = 3
            };
            Supervisor boby = new Supervisor
            {
                EmployeeID = 8,
                Name = "boby",
                Rating = 3
            };
            ronny.AddSubordinate(ricky);
            ronny.AddSubordinate(mike);
            ronny.AddSubordinate(maryann);

            boby.AddSubordinate(ginger);
            boby.AddSubordinate(olive);
            boby.AddSubordinate(candy);

            Console.WriteLine("\n---- Employee can see their Performance " +
                "Summary -------- ");
            ricky.PerformanceSummary();

            Console.WriteLine("\n---- Supervisor can also see their " +
                "subordinades Performance Summary -------- ");
            ronny.PerformanceSummary();

            Console.WriteLine("\n---- Subordinate Performance record: ");
            foreach (Employee employee in ronny.ListSubordinates)
            {
                employee.PerformanceSummary();
            }
        }
    }
}


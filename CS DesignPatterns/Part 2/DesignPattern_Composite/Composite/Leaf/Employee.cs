using Composite.IComponent;
using System;

namespace Composite.Leaf
{
    //'Leaf' class - will be leaf node in tree structure
    public class Employee : IEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public void PerformanceSummary()
        {
            Console.WriteLine("\nPerformance summary of employee: " +
                              $"{Name} is {Rating} out of 5");
        }
    }
}

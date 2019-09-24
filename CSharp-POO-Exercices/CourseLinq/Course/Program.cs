using System;
using System.Linq;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the Data Source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execute query
            foreach (var x in result)

            {
                Console.WriteLine(x);
            }
           
        }

}
}

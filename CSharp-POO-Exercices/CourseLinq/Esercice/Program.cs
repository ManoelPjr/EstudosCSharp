using System;
using System.Collections.Generic;
using Exercice.Entities;
using System.Linq;
using System.Globalization;
using System.IO;

namespace Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(',');
                        string name = lines[0];
                        string email = lines[1];
                        double salary = double.Parse(lines[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salary));
                    }
                };
                var emails = employees
                    .Where(e => e.Salary > value)
                    .OrderBy(e => e.Email)
                    .Select(e => e.Email);
                Console.Write("Email of people whose salary is more than " + value.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
                foreach (var email in emails)
                {
                    Console.WriteLine(email);
                }
                Console.WriteLine();
                var sum = employees
                    .Where(e => e.Name.StartsWith('M'))
                    .Sum(e => e.Salary);
                var sum2 = employees
                    .Where(e => e.Name[0] == 'M')
                    .Sum(e => e.Salary);
                Console.Write("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred!!");
                Console.WriteLine(e.Message);
            }
        }
    }
}

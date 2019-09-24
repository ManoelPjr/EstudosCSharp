using System;
using System.Globalization;

namespace DatasETempo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Construtores*/
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            /*Builders*/
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            /*Formatações e Parse*/
            DateTime p1 = DateTime.Parse("2000-08-15");
            DateTime p2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime p3 = DateTime.Parse("15/08/2000");
            DateTime p4 = DateTime.Parse("15/08/2000 13:05:59");

            /*Formatações e ParseExact*/
            DateTime pe1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime pe2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(pe1);
            Console.WriteLine(pe2);
        }
    }
}

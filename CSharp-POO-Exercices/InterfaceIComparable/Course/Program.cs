using System;
using System.IO;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee( sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (var emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            //string path = @"c:\temp\in.txt";

            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        List<string> list = new List<string>();
            //        while (!sr.EndOfStream)
            //        {
            //            list.Add(sr.ReadLine());
            //        }
            //        list.Sort();
            //        foreach (var name in list)
            //        {
            //            Console.WriteLine(name);
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}

using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            DateTime dt1 = new DateTime(2019, 06, 27, 19, 10, 45);
            Console.WriteLine(dt1.ElapsedTime());
            //-------------------------------//
            string s = "Good morning dear students!";
            Console.WriteLine(s.Cut(10));
            Console.WriteLine(s.Cut(4));

        }
    }
}

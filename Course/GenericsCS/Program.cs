using System;

namespace GenericsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();
            PrintService<string> printServiceStr = new PrintService<string>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine("First: " + printService.First());

            Console.Write("How many names? ");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                string x = Console.ReadLine();
                printServiceStr.AddValue(x);
            }
            printServiceStr.Print();
            Console.WriteLine("First: " + printServiceStr.First());
        }
    }
}

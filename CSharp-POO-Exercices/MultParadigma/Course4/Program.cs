using Course4.Entities;
using System;
using System.Collections.Generic;

namespace Course4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.00);
            list.RemoveAll(ProductTest);
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}

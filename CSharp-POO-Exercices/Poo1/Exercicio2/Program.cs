using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio2.Entities;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                
                switch (ch)
                {
                    case 'c' :
                        Product product = new Product(name, price);
                        list.Add(product);
                        break;
                    case 'i' :
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Product productImp = new ImportedProduct(name, price, customsFee);
                        list.Add(productImp);
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        Product productUsed = new UsedProduct(name, price, manufactureDate);
                        list.Add(productUsed);
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}

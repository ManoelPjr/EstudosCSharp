using Proxy.Classes;
using System;
/// <summary>
/// This code demonstrates the Proxy pattern for a Math object 
/// represented by a CalculateProxy object.
/// </summary>
namespace Proxy
{
    /// <summary>
    /// Proxy Design Pattern.
    /// </summary>
    class Client
    {
        static void Main()
        {
            // Create math proxy
            CalculateProxy proxy = new CalculateProxy();

            // Do some math
            Console.WriteLine("Calculations");
            Console.WriteLine("-------------");
            Console.WriteLine("\n10 + 5 = " + proxy.Add(10, 5));
            Console.WriteLine("\n10 - 5 = " + proxy.Subtract(10, 5));
            Console.WriteLine("\n10 * 5 = " + proxy.Multiply(10, 5));
            Console.WriteLine("\n10 / 5 = " + proxy.Divide(10, 5));

            // Wait for user
            Console.ReadKey();
        }
    }
}

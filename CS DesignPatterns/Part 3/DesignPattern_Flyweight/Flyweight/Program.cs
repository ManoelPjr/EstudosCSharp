using Flyweight.Classes;
using Flyweight.Interfaces;
using System;
/// <summary>
/// This code demonstrates the Flyweight pattern in which a relatively 
/// small number of shape objects is shared several times.
/// </summary>
namespace Flyweight
{
    /// <summary>
    /// Flyweight Design Pattern.
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            ShapeObjectFactory sof = new ShapeObjectFactory();

            IShape shape = sof.GetShape("Triangle");
            shape.Print();
            shape = sof.GetShape("Triangle");
            shape.Print();
            shape = sof.GetShape("Triangle");
            shape.Print();

            shape = sof.GetShape("Square");
            shape.Print();
            shape = sof.GetShape("Square");
            shape.Print();
            shape = sof.GetShape("Square");
            shape.Print();

            //shape = sof.GetShape("Circle"); //Exception
            //shape.Print();

            int total = sof.TotalObjectsCreated;
            Console.WriteLine($"\n Number of objects created = {total}");

            Console.ReadKey();
        }
    }







}

using Flyweight.Interfaces;
using System;

namespace Flyweight.Classes
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class Triangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Triangle");
        }
    }
}

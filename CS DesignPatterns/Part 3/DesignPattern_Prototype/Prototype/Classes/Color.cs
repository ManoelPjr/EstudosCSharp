using System;

namespace Prototype.Classes
{
    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class Color : ColorPrototype
    {
        private int _yellow;
        private int _orange;
        private int _purple;

        // Constructor
        public Color(int yellow, int orange, int purple)
        {
            this._yellow = yellow;
            this._orange = orange;
            this._purple = purple;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine(
              "RGB color is cloned to: {0,3},{1,3},{2,3}",
              _yellow, _orange, _purple);

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}

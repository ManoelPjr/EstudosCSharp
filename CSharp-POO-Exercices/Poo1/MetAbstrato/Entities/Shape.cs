using System;
using System.Collections.Generic;
using System.Text;
using MetAbstrato.Entities.Enums;

namespace MetAbstrato.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        //public Shape()
        //{
        //}

        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}

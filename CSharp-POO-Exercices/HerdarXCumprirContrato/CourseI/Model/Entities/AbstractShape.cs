using CourseI.Model.Enums;

namespace CourseI.Model.Entities
{
    abstract class AbstractShape : IShape
    {
         public Color Color { get; set; }

        public abstract double Area();
    }
}

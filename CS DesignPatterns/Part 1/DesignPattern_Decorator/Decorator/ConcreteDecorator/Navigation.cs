using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    // Concrete decorator
    public class Navigation: CarDecorator
    {
        public Navigation(Car car) : base(car)
        {
            Description = "Navigation";
        }
        public override double GetCarPrice() => _car.GetCarPrice() + 5000;

        public override string GetDescription() =>
            $"{_car.GetDescription()}, {Description}";
    }
}

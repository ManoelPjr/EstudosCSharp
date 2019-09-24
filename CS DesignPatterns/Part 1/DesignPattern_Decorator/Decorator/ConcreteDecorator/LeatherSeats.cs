using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    // Concrete Decorator
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car):base(car)
        {
            Description = "Leather seats";
        }
        public override double GetCarPrice() => _car.GetCarPrice() + 2500;

        public override string GetDescription() =>
            $"{_car.GetDescription()}, {Description}";
    }
}

using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    // Concrete component
    public class FullSizeCar: Car
    {
        public FullSizeCar()
        {
            Description = "Full size car!";
        }

        public override double GetCarPrice() => 30000.00;

        public override string GetDescription() => Description;
    }
}

using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    // Concrete component
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact car!";
        }
        public override double GetCarPrice() => 10000.00;

        public override string GetDescription() => Description;
        
    }
}

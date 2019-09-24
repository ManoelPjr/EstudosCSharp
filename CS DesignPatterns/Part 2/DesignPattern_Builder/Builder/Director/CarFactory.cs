using Builder.Builder;
using Builder.Product;

namespace Builder.Director
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class Carfactory
    {
        public Car Build(CarBuilder builder)
        {
            builder.SetHorsePower();
            builder.SetTopSpeed();
            builder.SetImpressiveFeature();
            builder.SetSeats();
            builder.SetDoors();
            return builder.GetCar();
        }
    }
}

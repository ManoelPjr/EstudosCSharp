using Builder.Product;

namespace Builder.Builder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    public abstract class CarBuilder
    {
        protected readonly Car _car = new Car();
        public abstract void SetHorsePower();
        public abstract void SetTopSpeed();
        public abstract void SetImpressiveFeature();
        public abstract void SetSeats();
        public abstract void SetDoors();

        public virtual Car GetCar()
        {
            return _car;
        }
    }
}

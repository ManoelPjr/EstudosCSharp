using Builder.Builder;

namespace Builder.ConcreteBuilder
{
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    public class SuperCarBuilder : CarBuilder
    {

        public override void SetHorsePower()
        {
            _car.HorsePower = 1640;
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 600;
        }
        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Can Fly";
        }

        public override void SetSeats()
        {
            _car.Seats = 2;
        }

        public override void SetDoors()
        {
            _car.Doors = 2;
        }
    }
}

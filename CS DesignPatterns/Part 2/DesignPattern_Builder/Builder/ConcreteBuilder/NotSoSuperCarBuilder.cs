using Builder.Builder;

namespace Builder.ConcreteBuilder
{
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    public class NotSoSuperCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 120;
        }
        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 70;
        }
        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Has Air Conditioning";
        }

        public override void SetSeats()
        {
            _car.Seats = 5;
        }

        public override void SetDoors()
        {
            _car.Doors = 5;
        }
    }
}

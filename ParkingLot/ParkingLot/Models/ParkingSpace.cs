using static Parking.Models.Spot;

namespace Parking.Models
{
    public abstract class ParkingSpace
    {
        public Spot[] Spots {  get; set; } = new Spot[20];
        public int SpotIndex { get; set; }
        public bool IsFull { get; set; }

        new static SpotType GetType()
        {
            return SpotType.BIKE;
        }
    }
}

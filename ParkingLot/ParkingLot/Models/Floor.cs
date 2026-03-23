namespace Parking.Models
{
    public class Floor
    {
        public CarParkingSpace CarParkingSpace { get; set; } = new CarParkingSpace();
        public BikeParkingSpace BikeParkingSpace { get; set; } = new BikeParkingSpace();
        public SuvParkingSpace SuvParkingSpace { get; set; } = new SuvParkingSpace();
    }
}

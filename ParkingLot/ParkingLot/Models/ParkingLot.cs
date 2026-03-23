namespace Parking.Models
{
    public class ParkingLot
    {
        public List<Floor>Floors = [];
        public required string LotId { get; set; }
        public bool IsLotOpen { get; set; }
    }
}

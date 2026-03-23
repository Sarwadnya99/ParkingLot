namespace Parking.Models
{
    public class Spot(string id)
    {
        public enum SpotType 
        {
            CAR = 10,
            BIKE = 5,
            SUV = 20
        };
        public SpotType Type { get; set; } = SpotType.BIKE;
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public string? RegNo { get; set; }
        public required string Id { get; set; } = id;
    }
}

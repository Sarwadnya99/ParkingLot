using System.Collections.Concurrent;
using Parking.Models;
using static Parking.Models.Spot;

namespace Parking.Helpers
{
    public static class CostHelper
    {
        private static readonly ConcurrentDictionary<SpotType, float> PriceChart = new(
            new Dictionary<SpotType, float>{
                { SpotType.BIKE, 10f },
                { SpotType.CAR, 20f },
                { SpotType.SUV, 30f }
            });
        public static float GetCost(Spot spot)
        {
            float cost = 10f;
            int hours = spot.ExitTime.Subtract(spot.EntryTime).Hours;
            if(hours == 0)
                return cost;
            PriceChart.TryGetValue(spot.Type, out float rate);
            cost = hours * rate;
            return cost;
        }
    }
}

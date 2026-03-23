using Microsoft.AspNetCore.Mvc;
using Parking.Models;

namespace Parking.Controllers
{
    [ApiController]
    [Route("Lots")]
    public class LotController : Controller
    {

        [HttpGet]
        [Route("{id}")]
        public ParkingLot GetParkingLotById(string id)
        {
            SarwadnyaParkingServices.ParkingLots.TryGetValue(id, out var parkingLot);
            return parkingLot;
        }
    }
}

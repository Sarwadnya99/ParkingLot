using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Parking.Models;

namespace Parking.Repository
{
    public class MongoRepository
    {
        IMongoCollection<ParkingLot> mongoCollection;
        public MongoRepository(IOptions<MongoSetting> Mongosettings)
        {
            var mongoClient = new MongoClient(Mongosettings.Value.ConnectionString);
            var database = mongoClient.GetDatabase(Mongosettings.Value.DatabaseName);
            var collection = database.GetCollection<ParkingLot>(Mongosettings.Value.CollectionName);
        }
    }
}

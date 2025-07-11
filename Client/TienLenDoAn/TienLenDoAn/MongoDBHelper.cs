using MongoDB.Driver;

namespace TienLenDoAn
{
    public static class MongoDBHelper
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase database = client.GetDatabase("TienLenDB");

        public static IMongoCollection<User> Users =>
            database.GetCollection<User>("Users");
    }
}

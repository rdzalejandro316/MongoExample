using MongoDB.Driver;

namespace ExampleMongoDB.Repositories
{
  public class MongoDBRepositoy
  {
    public MongoClient client;

    public IMongoDatabase db;
    
    public MongoDBRepositoy()
    {
      client = new MongoClient("mongodb+srv://sa:12345@cluster0.tgvqm2s.mongodb.net/?authSource=admin");
      db = client.GetDatabase("alejobd");

    }


  }
}

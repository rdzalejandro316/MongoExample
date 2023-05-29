using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ExampleMongoDB.Model
{
  public class Product
  {
    [BsonId]
    public ObjectId Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string Category { get; set; }

  }
}

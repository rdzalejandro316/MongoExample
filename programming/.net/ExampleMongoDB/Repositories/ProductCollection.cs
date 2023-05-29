using ExampleMongoDB.Model;
using Microsoft.VisualBasic;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExampleMongoDB.Repositories
{
  public class ProductCollection : IProductCollection
  {
    internal MongoDBRepositoy _repository = new MongoDBRepositoy();
    private IMongoCollection<Product> Collection;

    public ProductCollection()
    {
      Collection = _repository.db.GetCollection<Product>("Products");
    }

    public async Task DeleteProduct(string id)
    {
      var filter = Builders<Product>.Filter.Eq(c => c.Id, new ObjectId(id));
      await Collection.DeleteOneAsync(filter);
    }

    public async Task<List<Product>> GetAllProduct()
    {
      return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
    }

    public Task<Product> GetProductById(string id)
    {
      return Collection.FindAsync(new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
    }

    public async Task InsertProduct(Product product)
    {
      await Collection.InsertOneAsync(product);
    }

    public async Task UpdateProduct(Product product)
    {
      var filter = Builders<Product>
        .Filter
        .Eq(c => c.Id, product.Id);

      await Collection.ReplaceOneAsync(filter, product);
    }

  }
}

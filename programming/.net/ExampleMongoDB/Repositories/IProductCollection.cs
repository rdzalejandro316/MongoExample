using ExampleMongoDB.Model;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExampleMongoDB.Repositories
{
  public interface IProductCollection
  {
    Task InsertProduct(Product product);
    Task UpdateProduct(Product product);
    Task DeleteProduct(string id);
    Task<List<Product>> GetAllProduct();
    Task<Product> GetProductById(string id);



  }


}

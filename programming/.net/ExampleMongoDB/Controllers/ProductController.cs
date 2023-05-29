using ExampleMongoDB.Model;
using ExampleMongoDB.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExampleMongoDB.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProductController : ControllerBase
  {
    private IProductCollection products = new ProductCollection();

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
      var data = await products.GetAllProduct();
      return Ok(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductDetails(string id)
    {
      var data = await products.GetProductById(id);
      return Ok(data);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] Product product)
    {
      if (product == null) return BadRequest();

      await products.InsertProduct(product);
      return Created("Created",true);
    }

    [HttpPut]
    public async Task<IActionResult> CreateProduct([FromBody] Product product,string id)
    {
      if (product == null) return BadRequest();

      product.Id = new MongoDB.Bson.ObjectId(id);
      await products.UpdateProduct(product);
      return Created("Created", true);
    }


    [HttpDelete]
    public async Task<IActionResult> DeleteProduct(string id)
    {      
      await products.DeleteProduct(id);
      return NoContent();
    }



  }
}


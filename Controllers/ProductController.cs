using Microsoft.AspNetCore.Mvc;
using TechcareerDotnetBootcamp.Models;
using TechcareerDotnetBootcamp.Services;

namespace TechcareerDotnetBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // POST: api/product
        [HttpPost]
        public ActionResult<Product> Create(int id, string name, decimal unitPrice, Category category)
        {
            if (string.IsNullOrEmpty(name) || unitPrice <= 0 || category == null)
            {
                return BadRequest("Invalid input parameters");
            }

            ProductService.Create(id, name, unitPrice, category);
            return CreatedAtAction(nameof(GetById), new { id }, new { Id = id, Name = name, UnitPrice = unitPrice, Category = category });
        }

        // GET: api/product
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return ProductService.GetProducts();
        }

        // GET: api/product/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            Product product = ProductService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // DELETE: api/product/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Product product = ProductService.GetProductById(id);

            if (product == null)
            {
                return NotFound(); // Returns 404 Not Found if the product with the specified ID is not found.
            }

            ProductService.Delete(id);
            return NoContent(); // Returns 204 No Content if the product is successfully deleted.
        }
    }
}


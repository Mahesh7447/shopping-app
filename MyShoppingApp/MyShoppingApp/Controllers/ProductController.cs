using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShoppingApp.Models;
using MyShoppingApp.Services;

namespace MyShoppingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = productService.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(productService.GetProductById(id));
        }
        [HttpPost]
        public IActionResult SaveProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                return Ok(productService.SaveProduct(product));
            }
            return BadRequest();
        }
        [HttpPut]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                return Ok(productService.UpdateProduct(product));
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            bool status = false;
            if (id <= 0)
            {
                return BadRequest();
            }
            else
            {
                status = productService.DeleteProduct(id);
                if (status)
                {
                    return Ok(status);
                }
                else
                    return NotFound();
            }

        }
    }
}

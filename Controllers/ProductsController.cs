using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;
using ProductsApi.Services;

namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsService _service;

        public ProductsController(ProductsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Tuote>> GetAll()
        {
            var products = _service.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Tuote> GetById(int id)
        {
            var product = _service.GetProductById(id);
            if (product == null)
                return NotFound(new { message = "Tuotetta ei löytynyt" });

            return Ok(product);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;
using ProductsApi.Services;

namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoriesService _service;

        public CategoriesController(CategoriesService service)
        {
            _service = service;
        }

        // GET: /api/categories/
        [HttpGet]
        public ActionResult<List<Category>> GetAll()
        {
            var categories = _service.GetAllCategories();
            return Ok(categories);
        }

        // GET: /api/categories/{id}
        [HttpGet("{id}")]
        public ActionResult<Category> GetById(int id)
        {
            var category = _service.GetCategoryById(id);
            if (category == null)
                return NotFound(new { message = "Kategoriaa ei löytynyt" });

            return Ok(category);
        }

        // POST: /api/categories/
        [HttpPost]
        public ActionResult<Category> Create([FromBody] Category category)
        {
            if (string.IsNullOrWhiteSpace(category.Name))
                return BadRequest(new { message = "Kategorian nimi on pakollinen" });

            // Simuloidaan sisäänkirjautunut käyttäjä
            category.Owner = "test_user";

            var created = _service.CreateCategory(category);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }
    }
}

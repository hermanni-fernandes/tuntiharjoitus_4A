using ProductsApi.Models;

namespace ProductsApi.Repositories
{
    public class CategoriesRepository
    {
        private readonly List<Category> _categories = new()
        {
            new Category { Id = 1, Name = "Juomat", Owner = "admin" },
            new Category { Id = 2, Name = "Makeiset", Owner = "admin" }
        };

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category? GetById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public Category Add(Category category)
        {
            category.Id = _categories.Max(c => c.Id) + 1;
            _categories.Add(category);
            return category;
        }
    }
}

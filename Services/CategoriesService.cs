using ProductsApi.Models;
using ProductsApi.Repositories;

namespace ProductsApi.Services
{
    public class CategoriesService
    {
        private readonly CategoriesRepository _repository;

        public CategoriesService(CategoriesRepository repository)
        {
            _repository = repository;
        }

        public List<Category> GetAllCategories()
        {
            return _repository.GetAll();
        }

        public Category? GetCategoryById(int id)
        {
            return _repository.GetById(id);
        }

        public Category CreateCategory(Category category)
        {
            return _repository.Add(category);
        }
    }
}

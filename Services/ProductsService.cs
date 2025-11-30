using ProductsApi.Models;
using ProductsApi.Repositories;

namespace ProductsApi.Services
{
    public class ProductsService
    {
        private readonly ProductsRepository _repository;

        public ProductsService(ProductsRepository repository)
        {
            _repository = repository;
        }

        public List<Tuote> GetAllProducts()
        {
            return _repository.GetAll();
        }

        public Tuote? GetProductById(int id)
        {
            return _repository.GetById(id);
        }
    }
}

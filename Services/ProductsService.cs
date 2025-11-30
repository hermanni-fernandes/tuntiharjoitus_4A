using ProductsApi.Models;
using ProductsApi.Repositories;

namespace ProductsApi.Services
{
    public class ProductsService
    {
        private readonly ProductsRepository _repository;

        public ProductsService()
        {
            _repository = new ProductsRepository();
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

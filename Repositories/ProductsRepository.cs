using ProductsApi.Models;

namespace ProductsApi.Repositories
{
    public class ProductsRepository
    {
        private readonly List<Tuote> _tuotteet = new()
        {
            new Tuote { Id = 1, Nimi = "Kahvi", Kuvaus = "Tumma paahto kahvi", Hinta = 4.50 },
            new Tuote { Id = 2, Nimi = "Tee", Kuvaus = "Vihreä tee", Hinta = 3.20 },
            new Tuote { Id = 3, Nimi = "Suklaa", Kuvaus = "Maitosuklaa levy 200g", Hinta = 2.80 }
        };

        public List<Tuote> GetAll()
        {
            return _tuotteet;
        }

        public Tuote? GetById(int id)
        {
            return _tuotteet.FirstOrDefault(t => t.Id == id);
        }
    }
}

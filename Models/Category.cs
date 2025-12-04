namespace ProductsApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty; // Sisäänkirjautunut käyttäjä (mock)
    }
}

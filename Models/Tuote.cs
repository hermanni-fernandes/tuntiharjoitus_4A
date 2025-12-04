namespace ProductsApi.Models
{
    public class Tuote
    {
        public int Id { get; set; }
        public string Nimi { get; set; } = string.Empty;
        public string Kuvaus { get; set; } = string.Empty;
        public double Hinta { get; set; }

        // Jokaisen tuotteen pitää kuulua johonkin kategoriaan
        public int CategoryId { get; set; }
    }
}

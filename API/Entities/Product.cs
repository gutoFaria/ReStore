

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Descrition { get; set; } = String.Empty;
        public long Price { get; set; }
        public string PictureUrl { get; set; } = String.Empty;
        public string Type { get; set; } = String.Empty;
        public string Brand { get; set; } = String.Empty;
        public int QuantityInStock { get; set; }
    }
}
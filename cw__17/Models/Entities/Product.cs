namespace cw__17.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}

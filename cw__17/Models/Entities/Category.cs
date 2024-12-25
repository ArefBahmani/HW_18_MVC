namespace cw__17.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Product>? Products { get; set; } = new List<Product>();
    }
}

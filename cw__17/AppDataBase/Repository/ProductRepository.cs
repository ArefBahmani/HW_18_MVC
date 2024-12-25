using cw__17.Models.Contract.ProductContract;
using cw__17.Models.Entities;

namespace cw__17.AppDataBase.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository()
        {
            _context = new AppDbContext();
        }

        public void AddProduct(Product product)
        {
           _context.Products.Add(product);
        }

        public List<Product> GetAll()

       => _context.Products.ToList();
    }
}

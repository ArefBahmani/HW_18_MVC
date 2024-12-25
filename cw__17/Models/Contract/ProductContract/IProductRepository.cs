using cw__17.Models.Entities;
namespace cw__17.Models.Contract.ProductContract
{
    public interface IProductRepository
    {
       public List<Product> GetAll();
        public void AddProduct(Product product);
        
    }
}

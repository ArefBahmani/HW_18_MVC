using cw__17.Models.Entities;

namespace cw__17.Models.Contract.ProductContract
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public void CreatProduct(Product product);
    }
}

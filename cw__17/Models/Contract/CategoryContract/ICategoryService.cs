using cw__17.Models.Entities;

namespace cw__17.Models.Contract.CategoryContract
{
    public interface ICategoryService
    {
        public void Creat(Category category);
        public List<Category> GetAll();
    }
}

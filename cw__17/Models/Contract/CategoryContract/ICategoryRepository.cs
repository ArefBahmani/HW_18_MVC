using cw__17.Models.Entities;

namespace cw__17.Models.Contract.CategoryContract
{
    public interface ICategoryRepository
    {
        public void Creat(Category category);
        public List<Category> GetAll();
    }
}

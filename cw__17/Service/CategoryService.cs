using cw__17.AppDataBase.Repository;
using cw__17.Models.Contract.CategoryContract;
using cw__17.Models.Entities;

namespace cw__17.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }
        public void Creat(Category category)
        {
           
            _categoryRepository.Creat(category);
        }

        public List<Category> GetAll()

       => _categoryRepository.GetAll();
    }
}

using cw__17.AppDataBase;
using cw__17.Models.Contract.CategoryContract;
using cw__17.Models.Entities;
using cw__17.Service;
using Microsoft.AspNetCore.Mvc;

namespace cw__17.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService categoryService = new CategoryService();
        public IActionResult Index()
        {
            if(CurrentUser.CurentUser == null)
            {
                return Redirect("/Autentication/Login");
            }
            var cats = categoryService.GetAll();

            return View(cats);
        }
        [HttpPost]
        public IActionResult Add(string Title)
        {
            Category category = new Category() {Title =  Title};
            categoryService.Creat(category);
            return RedirectToAction("Index");

        } 
    }
}

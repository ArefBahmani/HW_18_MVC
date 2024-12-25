using cw__17.AppDataBase;
using cw__17.Models.Contract.ProductContract;
using cw__17.Models.Entities;
using cw__17.Service;
using Microsoft.AspNetCore.Mvc;

namespace cw__17.Controllers
{
    public class ProductController : Controller
    {


        IProductService _productService = new ProductService();
        public IActionResult Index()
        {
            if (CurrentUser.CurentUser == null)
            {
                return Redirect("/Autentication/Login");
            }
            var pro = _productService.GetAll();

            return View(pro);
        }
        public IActionResult Add(Product product)
        {
            var pro = new Product()
            {
                Name = product.Name,
                Price = product.Price,
                Category = product.Category,
                Count = product.Count
            };
           _productService.CreatProduct(pro);
            return RedirectToAction("Index");
        }
        
    }
}

using cw__17.AppDataBase;
using cw__17.Models.Contract.UserContract;
using cw__17.Service;
using Microsoft.AspNetCore.Mvc;

namespace cw__17.Controllers
{
    public class AutenticationController : Controller
    {
        IUserService _userService = new UserService();
      
       public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            if(_userService.Login(username, password) == false)
            {
                TempData["Message"] = "Username or Password is NotValid ";
                TempData["AlertType"] = "danger";
                return View();

            }
            
            TempData["Message"] = "You are Login";
            TempData["AlertType"] = "Success";
            return View();

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string firstname,string lastname,string username,string password)
        {
           
            if (_userService.Register(firstname, lastname, username, password) == false)
            {

                TempData["Message"] = "Username is Exist";
                TempData["AlertType"] = "danger";
                return View();
            }
            TempData["Message"] = "You are Register";
            TempData["AlertType"] = "Success";
            
            return View();
        }
        public IActionResult LogOut()
        {
            CurrentUser.CurentUser = null;
            return Redirect("/Autentication/Login");
        }

        
    }
}

using _20GRPEDC01BNT201__TP3.Models;
using _20GRPEDC01BNT201__TP3.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _20GRPEDC01BNT201__TP3.Controllers
{
    public class LoginController : Controller
    {
        AddLogin addLogin = new AddLogin();

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([Bind] LoginModel loginModel)
        {
            int result = addLogin.LoginCheck(loginModel);
            if (result == 1)
            {
                TempData["Message"] = "You are welcome to Admin Section";
                
            }
            else
            {
                TempData["Message"] = "Admin id or Password is wrong.!";
            }
            return View();

        }
    }
}
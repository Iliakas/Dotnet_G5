using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult  Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (model.Login == "said@gmail.com" && model.Password == "123")
                return RedirectToAction("Index", "Chat");
            return View();
        }
    }
}

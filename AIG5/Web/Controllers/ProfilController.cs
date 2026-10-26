using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ProfilController : Controller
    {
        public IActionResult Index()
        {

            return View()  ;
        }
        public String  ChangePassword()
        {
            return "Change Password";
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HistoriqueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

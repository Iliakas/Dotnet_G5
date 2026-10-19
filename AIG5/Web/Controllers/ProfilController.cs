using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ProfilController : Controller
    {
        public String Index()
        {
            UserModel user = new UserModel();
            user.LastName = "Doe";
            user.FirstName = "John";
            user.EMail = "john.doe@example.com";
            return user.LastName + ", " + user.FirstName + " (" + user.EMail + ")"  ;
        }
        public String  ChangePassword()
        {
            return "Change Password";
        }
    }
}

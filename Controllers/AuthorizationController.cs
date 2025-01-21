using Microsoft.AspNetCore.Mvc;

namespace Beauty_Salon.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Beauty_Salon.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

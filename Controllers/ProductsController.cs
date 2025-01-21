using Microsoft.AspNetCore.Mvc;

namespace Beauty_Salon.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

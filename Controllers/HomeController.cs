using Beauty_Salon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Beauty_Salon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

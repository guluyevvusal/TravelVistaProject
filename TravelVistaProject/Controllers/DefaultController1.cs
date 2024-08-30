using Microsoft.AspNetCore.Mvc;

namespace TravelVistaProject.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

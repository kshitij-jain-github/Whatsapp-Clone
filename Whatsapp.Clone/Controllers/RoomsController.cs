using Microsoft.AspNetCore.Mvc;

namespace Whatsapp.Clone.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

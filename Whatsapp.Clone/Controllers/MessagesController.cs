using Microsoft.AspNetCore.Mvc;

namespace Whatsapp.Clone.Controllers
{
    public class MessagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

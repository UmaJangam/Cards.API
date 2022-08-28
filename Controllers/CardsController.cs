using Microsoft.AspNetCore.Mvc;

namespace Cards.API.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

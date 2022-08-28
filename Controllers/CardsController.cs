using Microsoft.AspNetCore.Mvc;

namespace Cards.API.Controllers
{
    [ApiController]
    public class CardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

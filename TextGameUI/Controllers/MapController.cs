using Microsoft.AspNetCore.Mvc;

namespace TextGameUI.Controllers
{
    [Route("[controller]")]
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

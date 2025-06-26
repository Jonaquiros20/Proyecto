using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class RecetasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

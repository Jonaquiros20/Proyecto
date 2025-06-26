using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class ExpedientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

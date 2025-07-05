using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class CitasController : Controller
    {
        public IActionResult Index()
        {
            var citas = new List<Cita>
            {
                new Cita { Id = 1, Paciente = "Juan Pérez", Doctor = "Dra. Martínez", Fecha = new DateTime(2025, 7, 8, 9, 30, 0), Estado = "Confirmada" },
                new Cita { Id = 2, Paciente = "Ana Gómez", Doctor = "Dr. Rodríguez", Fecha = new DateTime(2025, 7, 8, 10, 45, 0), Estado = "Pendiente" },
                new Cita { Id = 3, Paciente = "Carlos Méndez", Doctor = "Dra. Morales", Fecha = new DateTime(2025, 7, 9, 14, 0, 0), Estado = "Cancelada" }
            };

            return View(citas);
        }
    }
}

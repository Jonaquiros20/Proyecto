using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class ExpedientesController : Controller
    {
        public IActionResult Index()
        {
            var expedientes = new List<Expediente>
            {
                new Expediente { Id = 1, Paciente = "María López", Doctor = "Dra. Martínez", Diagnostico = "Hipertensión", Fecha = new DateTime(2025, 7, 2) },
                new Expediente { Id = 2, Paciente = "Pedro Ramírez", Doctor = "Dr. Rodríguez", Diagnostico = "Asma leve", Fecha = new DateTime(2025, 6, 30) },
                new Expediente { Id = 3, Paciente = "Laura Vargas", Doctor = "Dra. Morales", Diagnostico = "Alergia crónica", Fecha = new DateTime(2025, 6, 25) }
            };

            return View(expedientes);
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class DoctoresController : Controller
    {
        public IActionResult Index()
        {
            var doctores = new List<Doctor>
            {
                new Doctor { Id = 1, Nombre = "Dra. Martínez", Especialidad = "Pediatría", Correo = "martinez@clinica.com", Telefono = "8888-1234" },
                new Doctor { Id = 2, Nombre = "Dr. Rodríguez", Especialidad = "Cardiología", Correo = "rodriguez@clinica.com", Telefono = "8877-4567" },
                new Doctor { Id = 3, Nombre = "Dra. Morales", Especialidad = "Dermatología", Correo = "morales@clinica.com", Telefono = "8866-7890" }
            };

            return View(doctores);
        }
    }
}
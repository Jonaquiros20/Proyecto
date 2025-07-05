using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class PacientesController : Controller
    {
        public IActionResult Index()
        {
            var pacientes = new List<Paciente>
            {
                new Paciente { Id = 1, Nombre = "María López", Edad = 34, Genero = "Femenino", Telefono = "8800-1234" },
                new Paciente { Id = 2, Nombre = "Pedro Ramírez", Edad = 29, Genero = "Masculino", Telefono = "8811-5678" },
                new Paciente { Id = 3, Nombre = "Laura Vargas", Edad = 41, Genero = "Femenino", Telefono = "8822-9876" }
            };

            return View(pacientes);
        }
    }
}
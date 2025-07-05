using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class RecetasController : Controller
    {
        public IActionResult Index()
        {
            var recetas = new List<Receta>
            {
                new Receta { Id = 1, Paciente = "María López", Doctor = "Dra. Martínez", Medicamento = "Paracetamol 500mg", Fecha = new DateTime(2025, 7, 3) },
                new Receta { Id = 2, Paciente = "Pedro Ramírez", Doctor = "Dr. Rodríguez", Medicamento = "Salbutamol Inhalador", Fecha = new DateTime(2025, 7, 1) },
                new Receta { Id = 3, Paciente = "Laura Vargas", Doctor = "Dra. Morales", Medicamento = "Loratadina 10mg", Fecha = new DateTime(2025, 6, 28) }
            };

            return View(recetas);
        }
    }
}
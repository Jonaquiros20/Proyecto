using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;
using System;
using System.Collections.Generic;

namespace Proyecto.Controllers
{
    public class ReportesController : Controller
    {
        public IActionResult Index()
        {
            var modelo = new ReporteViewModel
            {
                TotalPacientes = 125,
                TotalDoctores = 12,
                TotalCitas = 324,
                TotalRecetas = 198,
                CitasRecientes = new List<CitaReciente>
                {
                    new CitaReciente
                    {
                        Paciente = "Juan Pérez",
                        Doctor = "Dra. Martínez",
                        Fecha = new DateTime(2025, 7, 8, 9, 30, 0),
                        Estado = "Confirmada"
                    },
                    new CitaReciente
                    {
                        Paciente = "Laura Vargas",
                        Doctor = "Dra. Morales",
                        Fecha = new DateTime(2025, 7, 9, 11, 0, 0),
                        Estado = "Pendiente"
                    },
                    new CitaReciente
                    {
                        Paciente = "Pedro Ramírez",
                        Doctor = "Dr. Rodríguez",
                        Fecha = new DateTime(2025, 7, 10, 14, 0, 0),
                        Estado = "Cancelada"
                    }
                }
            };

            return View(modelo);
        }
    }
}

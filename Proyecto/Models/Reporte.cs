using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Proyecto.Models
{
    public class ReporteViewModel
    {
        public int TotalPacientes { get; set; }
        public int TotalDoctores { get; set; }
        public int TotalCitas { get; set; }
        public int TotalRecetas { get; set; }

        public List<CitaReciente> CitasRecientes { get; set; }
    }

    public class CitaReciente
    {
        public string Paciente { get; set; }
        public string Doctor { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } // Confirmada, Pendiente, Cancelada
    }
}
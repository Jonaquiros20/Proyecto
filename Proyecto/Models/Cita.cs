using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public string Paciente { get; set; }
        public string Doctor { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}


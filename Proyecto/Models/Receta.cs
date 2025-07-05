using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Models
{
    public class Receta
    {
        public int Id { get; set; }
        public string Paciente { get; set; }
        public string Doctor { get; set; }
        public string Medicamento { get; set; }
        public DateTime Fecha { get; set; }
    }
}

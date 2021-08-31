using System.Collections.Generic;
using System.Web.Mvc;
namespace ECCI_IS_Lab01_WebApp.Models
{
    public class CursoDetalles
    {
        public IEnumerable<SelectListItem> Cursos { get; set; }
        public int CantidadEstudiantes { get; set; }
        public double PromedioClase { get; set; }
    }
}
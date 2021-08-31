using ECCI_IS_Lab01_WebApp.Models;
using System.Collections.Generic;
using System;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web.Mvc;
namespace ECCI_IS_Lab01_WebApp.Controllers
{
    public class CursoDetallesController : Controller
    {
        private ECCI_IS_Lab01_DatosEntities3 db = new ECCI_IS_Lab01_DatosEntities3();
        // GET: CursoDetalles
        public ActionResult Index()
        {
            IEnumerable<SelectListItem> cursos = ObtenerCursos();
            var modelo = new CursoDetalles
            {
                Cursos = cursos,
                CantidadEstudiantes = ObtenerCantidadEstudiantes(
           Convert.ToInt32(cursos.First().Value)),
                PromedioClase = ObtenerPromedioClase(Convert.ToInt32(cursos.First().Value)),
            };
            return View(modelo);
        }
        private IEnumerable<SelectListItem> ObtenerCursos()
        {
            return db.Cursoes
                .Select(curso => new SelectListItem
                {
                    Value = curso.CursoID.ToString(),
                    Text = curso.Titulo
                }).ToList();
        }
        [HttpGet]
        public int ObtenerCantidadEstudiantes(int cursoId)
        {
            return db.Matriculas
            .Where(x => x.CursoID == cursoId)
            .Count();
        }
        [HttpGet]
        public double ObtenerPromedioClase(int cursoId)
        {
            //Parametro para que se guarde el resultado
            ObjectParameter resultado = new ObjectParameter("resultado", typeof(Double));
            //Invoca el metodo
            db.ProcObtenerPromedioCurso(cursoId, resultado);
            //Devuelve el resultado
            return Convert.ToDouble(resultado.Value);
        }
    }
}

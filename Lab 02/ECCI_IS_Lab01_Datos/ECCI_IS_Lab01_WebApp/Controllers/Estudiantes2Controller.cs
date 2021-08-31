using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECCI_IS_Lab01_WebApp.Models;
namespace ECCI_IS_Lab01_WebApp.Controllers
{
    public class Estudiante2Controller : Controller
    {
        private ECCI_IS_Lab01_DatosEntities3 db = new ECCI_IS_Lab01_DatosEntities3();
        // GET: /Estudiante2/
        public ActionResult Index()
        {
            var estudiantes = db.Estudiantes.Include(e => e.Ciudad).Include(e => e.Pai);
            return View(estudiantes.ToList());
        }
        // GET: /Estudiante2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
            {
                return HttpNotFound();
            }
            return View(estudiante);
        }
        // GET: /Estudiante2/Create
        public ActionResult Create()
        {
            ViewBag.CiudadId = new SelectList(db.Ciudads, "Id", "Nombre");
            ViewBag.PaisId = new SelectList(db.Pais, "Id", "Nombre");
            return View();
        }
        // POST: /Estudiante2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind
        //to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult
        Create([Bind(Include="EstudianteID,Apellido,Nombre,FechaMatricula,CorreoElectronico,PaisId,CiudadId")]
        Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                db.Estudiantes.Add(estudiante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CiudadId = new SelectList(db.Ciudads, "Id", "Nombre", estudiante.CiudadId);
            ViewBag.PaisId = new SelectList(db.Pais, "Id", "Nombre", estudiante.PaisId);
            return View(estudiante);
        }
        // GET: /Estudiante2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
            {
                return HttpNotFound();
            }
            var CiudadId = from s in db.Ciudads
                           select s;
            ViewBag.PaisId = new SelectList(db.Pais, "Id", "Nombre", estudiante.PaisId);

            if (!String.IsNullOrEmpty(estudiante.PaisId))
            {
                CiudadId = CiudadId.Where(s => s.PaisId.Equals(estudiante.PaisId));
            }
            ViewBag.CiudadId = new SelectList(CiudadId, "Id", "Nombre", estudiante.CiudadId);
            return View(estudiante);
        }
        // POST: /Estudiante2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind
        //to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include =
"EstudianteID,Apellido,Nombre,FechaMatricula,CorreoElectronico,PaisId,CiudadId")] Estudiante
estudiante, String ChangePaisId)
        {
            if (String.IsNullOrEmpty(ChangePaisId) && (ModelState.IsValid))
            {
                db.Entry(estudiante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var CiudadId = from s in db.Ciudads
                           select s;
            ViewBag.PaisId = new SelectList(db.Pais, "Id", "Nombre", estudiante.PaisId);
            if (!String.IsNullOrEmpty(estudiante.PaisId))
            {
                CiudadId = CiudadId.Where(s => s.PaisId.Equals(estudiante.PaisId));
            }
            ViewBag.CiudadId = new SelectList(CiudadId, "Id", "Nombre", estudiante.CiudadId);
            return View(estudiante);
        }
        // GET: /Estudiante2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
            {
                return HttpNotFound();
            }
            return View(estudiante);
        }
        // POST: /Estudiante2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estudiante estudiante = db.Estudiantes.Find(id);
            db.Estudiantes.Remove(estudiante);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

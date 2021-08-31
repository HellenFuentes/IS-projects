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
    public class VistaMatriculasController : Controller
    {
        private ECCI_IS_Lab01_DatosEntities3 db = new ECCI_IS_Lab01_DatosEntities3();

        // GET: VistaMatriculas
        public ActionResult Index()
        {
            return View(db.VistaMatriculas.ToList());
        }

        // GET: VistaMatriculas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VistaMatricula vistaMatricula = db.VistaMatriculas.Find(id);
            if (vistaMatricula == null)
            {
                return HttpNotFound();
            }
            return View(vistaMatricula);
        }

        // GET: VistaMatriculas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VistaMatriculas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MatriculaID,Nota,CursoID,EstudianteID")] VistaMatricula vistaMatricula)
        {
            if (ModelState.IsValid)
            {
                db.VistaMatriculas.Add(vistaMatricula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vistaMatricula);
        }

        // GET: VistaMatriculas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VistaMatricula vistaMatricula = db.VistaMatriculas.Find(id);
            if (vistaMatricula == null)
            {
                return HttpNotFound();
            }
            return View(vistaMatricula);
        }

        // POST: VistaMatriculas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MatriculaID,Nota,CursoID,EstudianteID")] VistaMatricula vistaMatricula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vistaMatricula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vistaMatricula);
        }

        // GET: VistaMatriculas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VistaMatricula vistaMatricula = db.VistaMatriculas.Find(id);
            if (vistaMatricula == null)
            {
                return HttpNotFound();
            }
            return View(vistaMatricula);
        }

        // POST: VistaMatriculas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VistaMatricula vistaMatricula = db.VistaMatriculas.Find(id);
            db.VistaMatriculas.Remove(vistaMatricula);
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

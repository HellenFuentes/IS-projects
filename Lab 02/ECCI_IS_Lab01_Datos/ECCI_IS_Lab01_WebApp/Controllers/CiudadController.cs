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
    public class CiudadController : Controller
    {
        private ECCI_IS_Lab01_DatosEntities3 db = new ECCI_IS_Lab01_DatosEntities3();
        // GET: /Ciudad/
        public ActionResult Index()
        {
            var ciudads = db.Ciudads.Include(c => c.Pai);
            return View("Index", ciudads.ToList());
        }
        // GET: /Ciudad/Details/5
        public ActionResult Details(string paisId, string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ciudad ciudad = db.Ciudads.Find(paisId, id);
            if (ciudad == null)
            {
                return HttpNotFound();
            }
            return View("Details", ciudad);
        }
        // GET: /Ciudad/Create
        public ActionResult Create()
        {
            ViewBag.PaisId = new SelectList(db.Pais, "Id", "Nombre");
            return View("Create");
        }
        // POST: /Ciudad/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PaisId,Id,Nombre")] Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                db.Ciudads.Add(ciudad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PaisId = new SelectList(db.Pais, "Id", "Nombre", ciudad.PaisId);
            return View("Create", ciudad);
        }
        // GET: /Ciudad/Edit/5
        public ActionResult Edit(string paisId, string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ciudad ciudad = db.Ciudads.Find(paisId, id);
            if (ciudad == null)
            {
                return HttpNotFound();
            }
            ViewBag.PaisId = new SelectList(db.Pais, "Id", "Nombre", ciudad.PaisId);
            return View("Edit", ciudad);
        }
        // POST: /Ciudad/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PaisId,Id,Nombre")] Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ciudad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PaisId = new SelectList(db.Pais, "Id", "Nombre", ciudad.PaisId);
            return View("Edit", ciudad);
        }
        // GET: /Ciudad/Delete/5
        public ActionResult Delete(string paisId, string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ciudad ciudad = db.Ciudads.Find(paisId, id);
            if (ciudad == null)
            {
                return HttpNotFound();
            }
            return View("Delete", ciudad);
        }
        // POST: /Ciudad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string paisId, string id)
        {
            Ciudad ciudad = db.Ciudads.Find(paisId, id);
            db.Ciudads.Remove(ciudad);
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

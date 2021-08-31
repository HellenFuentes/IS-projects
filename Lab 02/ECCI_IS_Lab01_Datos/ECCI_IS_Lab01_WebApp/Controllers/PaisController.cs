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
    public class PaisController : Controller
    {
        private ECCI_IS_Lab01_DatosEntities3 db;
        public PaisController()
        {
            db = new ECCI_IS_Lab01_DatosEntities3();
        }
        public PaisController(ECCI_IS_Lab01_DatosEntities3 db)
        {
            this.db = db;
        }
        // GET: /Pais/
        public ActionResult Index()
        {
            return View("Index", db.Pais.ToList());
        }
        // GET: /Pais/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pai pai = db.Pais.Find(id);
            if (pai == null)
            {
                return HttpNotFound();
            }
            return View("Details", pai);
        }
        // GET: /Pais/Create
        public ActionResult Create()
        {
            return View("Create");
        }
        // POST: /Pais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind  to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre")] Pai pai)
        {
            if (ModelState.IsValid)
            {
                db.Pais.Add(pai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", pai);
        }
        // GET: /Pais/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pai pai = db.Pais.Find(id);
            if (pai == null)
            {
                return HttpNotFound();
            }
            return View("Edit", pai);
        }
        // POST: /Pais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre")] Pai pai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", pai);
        }
        // GET: /Pais/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pai pai = db.Pais.Find(id);
            if (pai == null)
            {
                return HttpNotFound();
            }
            return View("Delete", pai);
        }
        // POST: /Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Pai pai = db.Pais.Find(id);
            db.Pais.Remove(pai);
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

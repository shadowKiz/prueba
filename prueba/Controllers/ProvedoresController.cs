using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using prueba.Data;
using prueba.Models;

namespace prueba.Controllers
{
    public class ProvedoresController : Controller
    {
        private pruebaContext db = new pruebaContext();

        // GET: Provedores
        public ActionResult Index()
        {
            return View(db.Provedores.ToList());
        }

        // GET: Provedores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provedores provedores = db.Provedores.Find(id);
            if (provedores == null)
            {
                return HttpNotFound();
            }
            return View(provedores);
        }

        // GET: Provedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Provedores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Tipotienda,URL")] Provedores provedores)
        {
            if (ModelState.IsValid)
            {
                db.Provedores.Add(provedores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(provedores);
        }

        // GET: Provedores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provedores provedores = db.Provedores.Find(id);
            if (provedores == null)
            {
                return HttpNotFound();
            }
            return View(provedores);
        }

        // POST: Provedores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Tipotienda,URL")] Provedores provedores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(provedores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(provedores);
        }

        // GET: Provedores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provedores provedores = db.Provedores.Find(id);
            if (provedores == null)
            {
                return HttpNotFound();
            }
            return View(provedores);
        }

        // POST: Provedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Provedores provedores = db.Provedores.Find(id);
            db.Provedores.Remove(provedores);
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

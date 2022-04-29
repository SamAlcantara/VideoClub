using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProgII_VideoClub.Models;
using EntityState = System.Data.Entity.EntityState;

namespace ProgII_VideoClub.Controllers
{
    public class ElencoController : Controller
    {
        private VideoClub_dbEntities db = new VideoClub_dbEntities();

        // GET: Elenco
        public ActionResult Index()
        {
            return View(db.Elencoes.ToList());
        }

        // GET: Elenco/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elenco elenco = db.Elencoes.Find(id);
            if (elenco == null)
            {
                return HttpNotFound();
            }
            return View(elenco);
        }

        // GET: Elenco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Elenco/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Estado")] Elenco elenco)
        {
            if (ModelState.IsValid)
            {
                db.Elencoes.Add(elenco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(elenco);
        }

        // GET: Elenco/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elenco elenco = db.Elencoes.Find(id);
            if (elenco == null)
            {
                return HttpNotFound();
            }
            return View(elenco);
        }

        // POST: Elenco/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Estado")] Elenco elenco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elenco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(elenco);
        }

        // GET: Elenco/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elenco elenco = db.Elencoes.Find(id);
            if (elenco == null)
            {
                return HttpNotFound();
            }
            return View(elenco);
        }

        // POST: Elenco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Elenco elenco = db.Elencoes.Find(id);
            db.Elencoes.Remove(elenco);
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

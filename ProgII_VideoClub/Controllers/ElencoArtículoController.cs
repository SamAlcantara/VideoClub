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
    public class ElencoArtículoController : Controller
    {
        private VideoClub_dbEntities db = new VideoClub_dbEntities();

        // GET: ElencoArtículo
        public ActionResult Index()
        {
            var elenco_articulo = db.Elenco_articulo.Include(e => e.Articulo1).Include(e => e.Elenco1);
            return View(elenco_articulo.ToList());
        }

        // GET: ElencoArtículo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elenco_articulo elenco_articulo = db.Elenco_articulo.Find(id);
            if (elenco_articulo == null)
            {
                return HttpNotFound();
            }
            return View(elenco_articulo);
        }

        // GET: ElencoArtículo/Create
        public ActionResult Create()
        {
            ViewBag.Articulo = new SelectList(db.Articulos, "ID", "Titulo");
            ViewBag.Elenco = new SelectList(db.Elencoes, "ID", "Nombre");
            return View();
        }

        // POST: ElencoArtículo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Articulo,Elenco,Rol")] Elenco_articulo elenco_articulo)
        {
            if (ModelState.IsValid)
            {
                db.Elenco_articulo.Add(elenco_articulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Articulo = new SelectList(db.Articulos, "ID", "Titulo", elenco_articulo.Articulo);
            ViewBag.Elenco = new SelectList(db.Elencoes, "ID", "Nombre", elenco_articulo.Elenco);
            return View(elenco_articulo);
        }

        // GET: ElencoArtículo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elenco_articulo elenco_articulo = db.Elenco_articulo.Find(id);
            if (elenco_articulo == null)
            {
                return HttpNotFound();
            }
            ViewBag.Articulo = new SelectList(db.Articulos, "ID", "Titulo", elenco_articulo.Articulo);
            ViewBag.Elenco = new SelectList(db.Elencoes, "ID", "Nombre", elenco_articulo.Elenco);
            return View(elenco_articulo);
        }

        // POST: ElencoArtículo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Articulo,Elenco,Rol")] Elenco_articulo elenco_articulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elenco_articulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Articulo = new SelectList(db.Articulos, "ID", "Titulo", elenco_articulo.Articulo);
            ViewBag.Elenco = new SelectList(db.Elencoes, "ID", "Nombre", elenco_articulo.Elenco);
            return View(elenco_articulo);
        }

        // GET: ElencoArtículo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elenco_articulo elenco_articulo = db.Elenco_articulo.Find(id);
            if (elenco_articulo == null)
            {
                return HttpNotFound();
            }
            return View(elenco_articulo);
        }

        // POST: ElencoArtículo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Elenco_articulo elenco_articulo = db.Elenco_articulo.Find(id);
            db.Elenco_articulo.Remove(elenco_articulo);
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

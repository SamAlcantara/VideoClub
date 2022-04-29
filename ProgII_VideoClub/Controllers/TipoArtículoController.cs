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
    public class TipoArtículoController : Controller
    {
        private VideoClub_dbEntities db = new VideoClub_dbEntities();

        // GET: TipoArtículo
        public ActionResult Index()
        {
            return View(db.Tipo_de_artículo.ToList());
        }

        // GET: TipoArtículo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_de_artículo tipo_de_artículo = db.Tipo_de_artículo.Find(id);
            if (tipo_de_artículo == null)
            {
                return HttpNotFound();
            }
            return View(tipo_de_artículo);
        }

        // GET: TipoArtículo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoArtículo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Descripcion,Estado")] Tipo_de_artículo tipo_de_artículo)
        {
            if (ModelState.IsValid)
            {
                db.Tipo_de_artículo.Add(tipo_de_artículo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipo_de_artículo);
        }

        // GET: TipoArtículo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_de_artículo tipo_de_artículo = db.Tipo_de_artículo.Find(id);
            if (tipo_de_artículo == null)
            {
                return HttpNotFound();
            }
            return View(tipo_de_artículo);
        }

        // POST: TipoArtículo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Descripcion,Estado")] Tipo_de_artículo tipo_de_artículo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipo_de_artículo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipo_de_artículo);
        }

        // GET: TipoArtículo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_de_artículo tipo_de_artículo = db.Tipo_de_artículo.Find(id);
            if (tipo_de_artículo == null)
            {
                return HttpNotFound();
            }
            return View(tipo_de_artículo);
        }

        // POST: TipoArtículo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tipo_de_artículo tipo_de_artículo = db.Tipo_de_artículo.Find(id);
            db.Tipo_de_artículo.Remove(tipo_de_artículo);
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

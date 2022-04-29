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
    public class ArtículosController : Controller
    {
        private VideoClub_dbEntities db = new VideoClub_dbEntities();

        // GET: Artículos
        public ActionResult Index()
        {
            var articulos = db.Articulos.Include(a => a.Idioma).Include(a => a.Tipo_de_artículo).Include(a => a.Elenco_articulo);
            return View(articulos.ToList());
        }

        // GET: Artículos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Articulo articulo = db.Articulos.Find(id);
            if (articulo == null)
            {
                return HttpNotFound();
            }
            return View(articulo);
        }

        // GET: Artículos/Create
        public ActionResult Create()
        {
            ViewBag.Idioma_ID = new SelectList(db.Idiomas, "ID", "Descripcion");
            ViewBag.Tipo_de_articulo_ID = new SelectList(db.Tipo_de_artículo, "ID", "Descripcion");
            ViewBag.ID = new SelectList(db.Elenco_articulo, "Articulo", "Rol");
            return View();
        }

        // POST: Artículos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Titulo,Tipo_de_articulo_ID,Idioma_ID,Renta_por_dia,Dias_de_renta,Monto_entrega_tardia,Estado")] Articulo articulo)
        {
            if (ModelState.IsValid)
            {
                db.Articulos.Add(articulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Idioma_ID = new SelectList(db.Idiomas, "ID", "Descripcion", articulo.Idioma_ID);
            ViewBag.Tipo_de_articulo_ID = new SelectList(db.Tipo_de_artículo, "ID", "Descripcion", articulo.Tipo_de_articulo_ID);
            ViewBag.ID = new SelectList(db.Elenco_articulo, "Articulo", "Rol", articulo.ID);
            return View(articulo);
        }

        // GET: Artículos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Articulo articulo = db.Articulos.Find(id);
            if (articulo == null)
            {
                return HttpNotFound();
            }
            ViewBag.Idioma_ID = new SelectList(db.Idiomas, "ID", "Descripcion", articulo.Idioma_ID);
            ViewBag.Tipo_de_articulo_ID = new SelectList(db.Tipo_de_artículo, "ID", "Descripcion", articulo.Tipo_de_articulo_ID);
            ViewBag.ID = new SelectList(db.Elenco_articulo, "Articulo", "Rol", articulo.ID);
            return View(articulo);
        }

        // POST: Artículos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Titulo,Tipo_de_articulo_ID,Idioma_ID,Renta_por_dia,Dias_de_renta,Monto_entrega_tardia,Estado")] Articulo articulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(articulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Idioma_ID = new SelectList(db.Idiomas, "ID", "Descripcion", articulo.Idioma_ID);
            ViewBag.Tipo_de_articulo_ID = new SelectList(db.Tipo_de_artículo, "ID", "Descripcion", articulo.Tipo_de_articulo_ID);
            ViewBag.ID = new SelectList(db.Elenco_articulo, "Articulo", "Rol", articulo.ID);
            return View(articulo);
        }

        // GET: Artículos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Articulo articulo = db.Articulos.Find(id);
            if (articulo == null)
            {
                return HttpNotFound();
            }
            return View(articulo);
        }

        // POST: Artículos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Articulo articulo = db.Articulos.Find(id);
            db.Articulos.Remove(articulo);
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

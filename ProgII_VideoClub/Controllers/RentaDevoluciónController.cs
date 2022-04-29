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
    public class RentaDevoluciónController : Controller
    {
        private VideoClub_dbEntities db = new VideoClub_dbEntities();

        // GET: RentaDevolución
        public ActionResult Index()
        {
            var renta_Devolucion = db.Renta_Devolucion.Include(r => r.Cliente1).Include(r => r.Empleado1).Include(r => r.Articulo1);
            return View(renta_Devolucion.ToList());
        }

        // GET: RentaDevolución/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Renta_Devolucion renta_Devolucion = db.Renta_Devolucion.Find(id);
            if (renta_Devolucion == null)
            {
                return HttpNotFound();
            }
            return View(renta_Devolucion);
        }

        // GET: RentaDevolución/Create
        public ActionResult Create()
        {
            ViewBag.Cliente = new SelectList(db.Clientes, "ID", "Nombre");
            ViewBag.Empleado = new SelectList(db.Empleados, "ID", "Nombre");
            ViewBag.Articulo = new SelectList(db.Articulos, "ID", "Titulo");
            return View();
        }

        // POST: RentaDevolución/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Num_de_renta,Empleado,Articulo,Cliente,Fecha_renta,Fecha_devolucion,Renta_por_dia,Dias_de_renta,Comentario,Estado")] Renta_Devolucion renta_Devolucion)
        {
            if (ModelState.IsValid)
            {
                db.Renta_Devolucion.Add(renta_Devolucion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cliente = new SelectList(db.Clientes, "ID", "Nombre", renta_Devolucion.Cliente);
            ViewBag.Empleado = new SelectList(db.Empleados, "ID", "Nombre", renta_Devolucion.Empleado);
            ViewBag.Articulo = new SelectList(db.Articulos, "ID", "Titulo", renta_Devolucion.Articulo);
            return View(renta_Devolucion);
        }

        // GET: RentaDevolución/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Renta_Devolucion renta_Devolucion = db.Renta_Devolucion.Find(id);
            if (renta_Devolucion == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cliente = new SelectList(db.Clientes, "ID", "Nombre", renta_Devolucion.Cliente);
            ViewBag.Empleado = new SelectList(db.Empleados, "ID", "Nombre", renta_Devolucion.Empleado);
            ViewBag.Articulo = new SelectList(db.Articulos, "ID", "Titulo", renta_Devolucion.Articulo);
            return View(renta_Devolucion);
        }

        // POST: RentaDevolución/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Num_de_renta,Empleado,Articulo,Cliente,Fecha_renta,Fecha_devolucion,Renta_por_dia,Dias_de_renta,Comentario,Estado")] Renta_Devolucion renta_Devolucion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(renta_Devolucion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cliente = new SelectList(db.Clientes, "ID", "Nombre", renta_Devolucion.Cliente);
            ViewBag.Empleado = new SelectList(db.Empleados, "ID", "Nombre", renta_Devolucion.Empleado);
            ViewBag.Articulo = new SelectList(db.Articulos, "ID", "Titulo", renta_Devolucion.Articulo);
            return View(renta_Devolucion);
        }

        // GET: RentaDevolución/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Renta_Devolucion renta_Devolucion = db.Renta_Devolucion.Find(id);
            if (renta_Devolucion == null)
            {
                return HttpNotFound();
            }
            return View(renta_Devolucion);
        }

        // POST: RentaDevolución/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Renta_Devolucion renta_Devolucion = db.Renta_Devolucion.Find(id);
            db.Renta_Devolucion.Remove(renta_Devolucion);
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

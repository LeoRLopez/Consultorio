using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DepositoDeAlimentos.Models;

namespace DepositoDeAlimentos.Controllers
{
    public class PresentadoController : Controller
    {
        private DepositoEntities db = new DepositoEntities();

        // GET: Presentado
        public ActionResult Index()
        {
            var presentado = db.Presentado.Include(p => p.Envase).Include(p => p.Producto);
            return View(presentado.ToList());
        }

        // GET: Presentado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presentado presentado = db.Presentado.Find(id);
            if (presentado == null)
            {
                return HttpNotFound();
            }
            return View(presentado);
        }

        // GET: Presentado/Create
        public ActionResult Create()
        {
            ViewBag.IdEnvase = new SelectList(db.Envase, "IdEnvase", "Descripcion");
            ViewBag.IdProducto = new SelectList(db.Producto, "IdProducto", "RNE");
            return View();
        }

        // POST: Presentado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPresentado,IdProducto,IdEnvase")] Presentado presentado)
        {
            if (ModelState.IsValid)
            {
                db.Presentado.Add(presentado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEnvase = new SelectList(db.Envase, "IdEnvase", "Descripcion", presentado.IdEnvase);
            ViewBag.IdProducto = new SelectList(db.Producto, "IdProducto", "RNE", presentado.IdProducto);
            return View(presentado);
        }

        // GET: Presentado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presentado presentado = db.Presentado.Find(id);
            if (presentado == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEnvase = new SelectList(db.Envase, "IdEnvase", "Descripcion", presentado.IdEnvase);
            ViewBag.IdProducto = new SelectList(db.Producto, "IdProducto", "RNE", presentado.IdProducto);
            return View(presentado);
        }

        // POST: Presentado/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPresentado,IdProducto,IdEnvase")] Presentado presentado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(presentado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEnvase = new SelectList(db.Envase, "IdEnvase", "Descripcion", presentado.IdEnvase);
            ViewBag.IdProducto = new SelectList(db.Producto, "IdProducto", "RNE", presentado.IdProducto);
            return View(presentado);
        }

        // GET: Presentado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presentado presentado = db.Presentado.Find(id);
            if (presentado == null)
            {
                return HttpNotFound();
            }
            return View(presentado);
        }

        // POST: Presentado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Presentado presentado = db.Presentado.Find(id);
            db.Presentado.Remove(presentado);
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
